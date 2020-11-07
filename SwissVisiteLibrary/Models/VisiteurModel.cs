using System;

namespace SwissVisiteLibrary.Models
{
    /// <summary>
    /// Modélise un visiteur médical travaillant pour GSB.
    /// </summary>
    public class VisiteurModel
    {
        #region Propriétés

        /// <summary>
        /// N° de matricule du visiteur 
        /// </summary>
        public string Matricule { get; set; }

        /// <summary>
        /// Nom de famille du visiteur
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du visiteur
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Adresse du visiteur
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Code Postal du visiteur
        /// </summary>
        public string CodePostal { get; set; }

        /// <summary>
        /// Ville du visiteur
        /// </summary>
        public string Ville { get; set; }

        /// <summary>
        /// Date d'embauche du visiteur
        /// </summary>
        public DateTime DateEmbauche { get; set; }

        /// <summary>
        /// Nom complet du visiteur
        /// </summary>
        public string NomPrenom
        {
            get
            {
                return (Prenom == null || Nom == null) ? null : $"{ Nom.ToUpper() } { Prenom }";
            }
        }

        #endregion
    }
}
