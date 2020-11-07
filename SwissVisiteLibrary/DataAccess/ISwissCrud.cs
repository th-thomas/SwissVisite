using SwissVisiteLibrary.Models;
using System.Collections.Generic;

namespace SwissVisiteLibrary.DataAccess
{
    /// <summary>
    /// Contrat pour les connecteurs de données, qui doivent
    /// impérativement comporter les méthodes de l'interface
    /// pour récupérer ou enregistrer les données depuis
    /// ou vers une base de données / des fichiers texte, etc. 
    /// </summary>
    public interface ISwissCrud
    {
        /// <summary>
        /// Récupère toutes les familles de médicaments GSB.
        /// </summary>
        /// <returns>Une liste d'objets FamilleMedicModel.</returns>
        List<FamilleMedicModel> FamilleMedicModel_GetAll();

        /// <summary>
        /// Récupère tous les médicaments GSB.
        /// </summary>
        /// <returns>Une liste d'objets MedicamentModel.</returns>
        List<MedicamentModel> MedicamentModel_GetAll();

        /// <summary>
        /// Récupère tous les praticiens.
        /// </summary>
        /// <returns>Une liste d'objets PraticienModel.</returns>
        List<PraticienModel> PraticienModel_GetAll();

        /// <summary>
        /// Récupère tous les visiteurs médicaux GSB.
        /// </summary>
        /// <returns>Une liste d'objets VisiteurModel.</returns>
        List<VisiteurModel> VisiteurModel_GetAll();

        /// <summary>
        /// Récupère tous les rapports d'un visiteur
        /// (par exemple : tous les rapports du visiteur connecté à l'application).
        /// </summary>
        /// <param name="visiteur">Le visiteur médical dont les rapports doivent être récupérés.</param>
        /// <returns>Une liste d'objets RapportVisiteModel.</returns>
        List<RapportVisiteModel> RapportVisiteModel_GetByVisiteur(VisiteurModel visiteur);

        /// <summary>
        /// Enregistre un nouveau rapport de visite dans la base de données.
        /// </summary>
        /// <param name="rapport">Le rapport de visite à ajouter à la base de données.</param>
        void RapportVisite_Save(RapportVisiteModel rapport);
    }
}
