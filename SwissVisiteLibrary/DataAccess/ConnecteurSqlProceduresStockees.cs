using Dapper;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace SwissVisiteLibrary.DataAccess
{
    /// <summary>
    /// Connecteur SQL (MySQL, SQL Server) utilisant le micro-ORM Dapper,
    /// des procédures stockées (SP) et des transactions.
    /// Implémente l'interface ISwissCrud.
    /// </summary>
    public class ConnecteurSqlProceduresStockees : BaseConnecteurSql, ISwissCrud
    {
        public ConnecteurSqlProceduresStockees(ServeurSql typeSql) : base(typeSql)
        {
        }

        public List<FamilleMedicModel> FamilleMedicModel_GetAll()
        {
            List<FamilleMedicModel> output; 
            
            using (IDbConnection conn = ConnexionBdd())
            {
                output = conn.Query<FamilleMedicModel>("spFamilleMedic_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public List<MedicamentModel> MedicamentModel_GetAll()
        {
            List<MedicamentModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                output = conn.Query<MedicamentModel, FamilleMedicModel, MedicamentModel>(
                    "spMedicament_GetAll",
                    (medic, fam) =>
                    {
                        medic.Famille = fam;
                        return medic;
                    },
                    splitOn: "Code",
                    commandType: CommandType.StoredProcedure
                    ).ToList();
            }

            return output;
        }

        public List<PraticienModel> PraticienModel_GetAll()
        {
            List<PraticienModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                output = conn.Query<PraticienModel, TypePraticienModel, PraticienModel>(
                    "spPraticien_GetAll",
                    (prat, typ) =>
                    {
                        prat.TypePraticien = typ;
                        return prat;
                    },
                    splitOn: "Code",
                    commandType: CommandType.StoredProcedure
                    ).ToList();
            }

            return output;
        }

        public List<RapportVisiteModel> RapportVisiteModel_GetByVisiteur(VisiteurModel visiteur)
        {
            List<RapportVisiteModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                var p = new DynamicParameters();
                p.Add("Matricule", visiteur.Matricule);

                output = conn.Query<RapportVisiteModel>("spRapportVisite_GetByVisiteur", p, commandType: CommandType.StoredProcedure).ToList();

                foreach (RapportVisiteModel rapport in output)
                {
                    rapport.Praticien = PraticienModel_GetByRapport(rapport);
                    rapport.Visiteur = visiteur;
                    rapport.LesEchantillons = Echantillons_GetByRapport(rapport);
                }
            }

            return output;
        }

        private PraticienModel PraticienModel_GetByRapport(RapportVisiteModel rapport)
        {
            PraticienModel output;

            using (IDbConnection conn = ConnexionBdd())
            {
                var p = new DynamicParameters();
                p.Add("Numero", rapport.Numero);

                output = conn.Query<PraticienModel, TypePraticienModel, PraticienModel>(
                    "spPraticien_GetByRapportVisite",
                    (prat, typ) =>
                    {
                        prat.TypePraticien = typ;
                        return prat;
                    },
                    p,
                    splitOn: "Code",
                    commandType: CommandType.StoredProcedure
                    ).First();
            }

            return output;
        }

        private Dictionary<MedicamentModel, int> Echantillons_GetByRapport(RapportVisiteModel rapport)
        {
            Dictionary<MedicamentModel, int> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                var p = new DynamicParameters();
                p.Add("Numero", rapport.Numero);

                output = conn.Query<MedicamentModel, FamilleMedicModel, int, KeyValuePair<MedicamentModel, int>>(
                    "spPresenter_GetByRapport",
                    (medic, fam, qte) =>
                    {
                        medic.Famille = fam;
                        return new KeyValuePair<MedicamentModel, int>(medic, qte);
                    },
                    p,
                    splitOn: "Code,Nombre_Echantillon",
                    commandType: CommandType.StoredProcedure
                    ).ToDictionary(x => x.Key, x => x.Value);
            }

            return output;
        }

        public List<VisiteurModel> VisiteurModel_GetAll()
        {
            List<VisiteurModel> output;

            using (IDbConnection conn = ConnexionBdd())
            {
                output = conn.Query<VisiteurModel>("spVisiteur_GetAll", commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }

        public void RapportVisite_Save(RapportVisiteModel rapport)
        {
            using (IDbConnection conn = ConnexionBdd())
            {
                conn.Open();

                using (IDbTransaction trans = conn.BeginTransaction())
                {
                    // On confie une partie du travail à deux sous-procédures :
                    RapportVisite_SaveRapportPraticienVisiteur(conn, trans, rapport);

                    if (rapport.LesEchantillons != null)
                        RapportVisite_SaveEchantillons(conn, trans, rapport);

                    trans.Commit();
                }
            }
        }

        /// <summary>
        /// Enregistre un rapport de visite avec ses données (sans les échantillons).
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="rapport">Le rapport de visite dont on veut enregistrer les données (sans les échantillons).</param>
        private void RapportVisite_SaveRapportPraticienVisiteur(IDbConnection conn, IDbTransaction trans, RapportVisiteModel rapport)
        {
            var p = new DynamicParameters();
            p.Add("Date", rapport.Date);
            p.Add("Bilan", rapport.Bilan);
            p.Add("Motif", rapport.Motif);
            p.Add("NumeroPrat", Convert.ToInt32(rapport.Praticien.Numero));
            p.Add("MatriculeVis", rapport.Visiteur.Matricule);
            p.Add("Numero", dbType: DbType.Int32, direction: ParameterDirection.Output);

            conn.Execute("spRapportVisite_Create", p, transaction: trans, commandType: CommandType.StoredProcedure);
            rapport.Numero = p.Get<int>("Numero").ToString();
        }

        /// <summary>
        /// Enregistre les échantillons d'un rapport de visite.
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <param name="rapport">Le rapport de visite dont on veut enregistrer les échantillons.</param>
        private void RapportVisite_SaveEchantillons(IDbConnection conn, IDbTransaction trans, RapportVisiteModel rapport)
        {
            foreach (KeyValuePair<MedicamentModel, int> echantillon in rapport.LesEchantillons)
            {
                var p = new DynamicParameters();
                p.Add("Numero", rapport.Numero);
                p.Add("DepotLegal", echantillon.Key.DepotLegal);
                p.Add("NombreEchantillon", echantillon.Value);

                conn.Execute("spPresenter_Create", p, transaction: trans, commandType: CommandType.StoredProcedure);
            }

            return;
        }
    }
}
