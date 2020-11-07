using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using SwissVisiteLibrary.Models;

namespace SwissVisiteLibrary.DataAccess
{
    /// <summary>
    /// Connecteur SQL (MySQL, SQL Server) utilisant le micro-ORM Dapper.
    /// Implémente l'interface ISwissCrud.
    /// </summary>
    public class ConnecteurSqlStandard : BaseConnecteurSql, ISwissCrud
    {
        public ConnecteurSqlStandard(ServeurSql typeSql) : base(typeSql)
        {
        }

        public List<FamilleMedicModel> FamilleMedicModel_GetAll()
        {
            List<FamilleMedicModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT FAM_CODE Code, FAM_LIBELLE Libelle 
                                FROM famillemedic
                                ORDER BY FAM_LIBELLE ASC";

                output = conn.Query<FamilleMedicModel>(sql).ToList();
            }

            return output;
        }

        public List<MedicamentModel> MedicamentModel_GetAll()
        {
            List<MedicamentModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT MED_DEPOTLEGAL DepotLegal, MED_NOMCOMMERCIAL NomCommercial, MED_COMPOSITION Composition, MED_EFFETS Effets, 
                                MED_CONTREINDIC ContreIndications, MED_PRIXECHANTILLON PrixEchantillon, m.FAM_CODE Code, FAM_LIBELLE Libelle 
                                FROM medicament m
                                LEFT JOIN famillemedic f ON m.FAM_CODE = f.FAM_CODE
                                ORDER BY MED_NOMCOMMERCIAL ASC";

                output = conn.Query<MedicamentModel, FamilleMedicModel, MedicamentModel>(
                    sql,
                    (medic, fam) =>
                    {
                        medic.Famille = fam;
                        return medic;
                    },
                    splitOn: "Code"
                    ).ToList();
            }

            return output;
        }

        public List<PraticienModel> PraticienModel_GetAll()
        {
            List<PraticienModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT PRA_NUM Numero, PRA_NOM Nom, PRA_PRENOM Prenom, PRA_ADRESSE Adresse, PRA_CP CodePostal, PRA_VILLE Ville,
                                PRA_COEFNOTORIETE CoeffNotoriete, p.TYP_CODE Code, TYP_LIBELLE Libelle, TYP_LIEU Lieu
                                FROM praticien p
                                LEFT JOIN typepraticien t ON p.TYP_CODE = t.TYP_CODE
                                ORDER BY PRA_NOM ASC";

                output = conn.Query<PraticienModel, TypePraticienModel, PraticienModel>(
                    sql,
                    (prat, typ) =>
                    {
                        prat.TypePraticien = typ;
                        return prat;
                    },
                    splitOn: "Code"
                    ).ToList();
            }

            return output;
        }

        public List<RapportVisiteModel> RapportVisiteModel_GetByVisiteur(VisiteurModel visiteur)
        {
            List<RapportVisiteModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT RAP_NUM Numero, RAP_DATE Date, RAP_BILAN Bilan, RAP_MOTIF Motif
                                FROM rapportvisite
                                WHERE VIS_MATRICULE = @Matricule
                                ORDER BY RAP_DATE ASC";

                output = conn.Query<RapportVisiteModel>(sql, new { Matricule = visiteur.Matricule }).ToList();

                foreach (RapportVisiteModel rapport in output)
                {
                    rapport.Praticien = PraticienModel_GetByRapport(rapport);
                    rapport.Visiteur = visiteur;
                    rapport.LesEchantillons = Echantillons_GetByRapport(rapport);
                }
            }

            return output;
        }

        /// <summary>
        /// Récupère le praticien d'un rapport de visite.
        /// </summary>
        /// <param name="rapport">Le rapport de visite dont on veut connaître le praticien.</param>
        /// <returns>Un objet PraticienModel.</returns>
        private PraticienModel PraticienModel_GetByRapport(RapportVisiteModel rapport)
        {
            PraticienModel output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT pra.PRA_NUM Numero, PRA_NOM Nom, PRA_PRENOM Prenom, PRA_ADRESSE Adresse, PRA_CP CodePostal, PRA_VILLE Ville, PRA_COEFNOTORIETE CoeffNotoriete,
                                typ.TYP_CODE Code, TYP_LIBELLE Libelle, TYP_LIEU Lieu
                                FROM praticien pra
                                INNER JOIN rapportvisite rap ON pra.PRA_NUM = rap.PRA_NUM
                                LEFT JOIN typepraticien typ ON pra.TYP_CODE = typ.TYP_CODE
                                WHERE rap.RAP_NUM = @Numero";

                output = conn.Query<PraticienModel, TypePraticienModel, PraticienModel>(
                    sql,
                    (prat, typ) =>
                    {
                        prat.TypePraticien = typ;
                        return prat;
                    },
                    new { Numero = rapport.Numero },
                    splitOn: "Code"
                    ).First();
            }

            return output;
        }

        /// <summary>
        /// Obtient l'ensemble des échantillons proposés lors d'une visite.
        /// </summary>
        /// <param name="rapport">Le rapport dont on veut connaître les échantillons.</param>
        /// <returns>Un dictionnaire de MedicamentModels et de leur quantité respective (entier).</returns>
        private Dictionary<MedicamentModel, int> Echantillons_GetByRapport(RapportVisiteModel rapport)
        {
            Dictionary<MedicamentModel, int> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT med.MED_DEPOTLEGAL DepotLegal, MED_NOMCOMMERCIAL NomCommercial, MED_COMPOSITION Composition,
                                MED_EFFETS Effets, MED_CONTREINDIC ContreIndications, MED_PRIXECHANTILLON PrixEchantillon,
                                fam.FAM_CODE Code, FAM_LIBELLE Libelle,
                                Nombre_Echantillon
                                FROM presenter pre
                                LEFT JOIN medicament med ON pre.MED_DEPOTLEGAL = med.MED_DEPOTLEGAL
                                LEFT JOIN famillemedic fam ON med.FAM_CODE = fam.FAM_CODE
                                WHERE RAP_NUM = @Numero";

                output = conn.Query<MedicamentModel, FamilleMedicModel, int, KeyValuePair<MedicamentModel, int>>(
                    sql,
                    (medic, fam, qte) =>
                    {
                        medic.Famille = fam;
                        return new KeyValuePair<MedicamentModel, int>(medic, qte);
                    },
                    new { Numero = rapport.Numero },
                    splitOn: "Code,Nombre_Echantillon"
                    ).ToDictionary(x => x.Key, x => x.Value);
            }

            return output;
        }

        public List<VisiteurModel> VisiteurModel_GetAll()
        {
            List<VisiteurModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                string sql = @"SELECT VIS_MATRICULE Matricule, VIS_NOM Nom, VIS_PRENOM Prenom, VIS_ADRESSE Adresse,
                                VIS_CP CodePostal, VIS_VILLE Ville, VIS_DATEEMBAUCHE DateEmbauche
                                FROM visiteur
                                ORDER BY VIS_NOM ASC";

                output = conn.Query<VisiteurModel>(sql).ToList();
            }

            return output;
        }

        public void RapportVisite_Save(RapportVisiteModel rapport)
        {
            using (IDbConnection conn = ConnexionBdd())
            {
                rapport.Numero = GenererIdRapport(conn).ToString();

                RapportVisite_SaveRapportPraticienVisiteur(conn, rapport);

                if (rapport.LesEchantillons != null)
                {
                    RapportVisite_SaveEchantillons(conn, rapport);
                }
            }                
        }

        /// <summary>
        /// Génère un id pour le rapport de visite
        /// (la clé primaire n'est pas de type auto-incrément).
        /// </summary>
        private int GenererIdRapport(IDbConnection conn)
        {
            return conn.ExecuteScalar<int>("SELECT 1 + MAX(CAST(RAP_NUM AS INT)) FROM rapportvisite");
        }

        /// <summary>
        /// Enregistre un rapport de visite avec ses données (sans les échantillons).
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="rapport">Le rapport de visite dont on veut enregistrer les données (sans les échantillons).</param>
        private void RapportVisite_SaveRapportPraticienVisiteur(IDbConnection conn, RapportVisiteModel rapport)
        {
            string sql = @"INSERT INTO rapportvisite (RAP_NUM, RAP_DATE, RAP_BILAN, RAP_MOTIF, PRA_NUM, VIS_MATRICULE)
                            VALUES (@Numero, @Date, @Bilan, @Motif, @NumeroPrat, @MatriculeVis)";

            var p = new DynamicParameters();
            p.Add("@Numero", rapport.Numero);
            p.Add("@Date", rapport.Date);
            p.Add("@Bilan", rapport.Bilan);
            p.Add("@Motif", rapport.Motif);
            p.Add("@NumeroPrat", Convert.ToInt32(rapport.Praticien.Numero));
            p.Add("@MatriculeVis", rapport.Visiteur.Matricule);

            conn.Execute(sql, p);
        }

        /// <summary>
        /// Enregistre les échantillons d'un rapport de visite.
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="rapport">Le rapport de visite dont on veut enregistrer les échantillons.</param>
        private void RapportVisite_SaveEchantillons(IDbConnection conn, RapportVisiteModel rapport)
        {
            string sql = @"INSERT INTO presenter (RAP_NUM, MED_DEPOTLEGAL, Nombre_Echantillon)
                            VALUES (@Numero, @DepotLegal, @NombreEchantillon)";

            foreach (KeyValuePair<MedicamentModel, int> echantillon in rapport.LesEchantillons)
            {
                string depotLegal = echantillon.Key.DepotLegal;
                int nombreEchantillon = echantillon.Value;
                conn.Execute(sql, new { Numero = rapport.Numero, DepotLegal = depotLegal, NombreEchantillon = nombreEchantillon });
            }

            return;
        }
    }
}
