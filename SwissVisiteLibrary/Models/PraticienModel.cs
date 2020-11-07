namespace SwissVisiteLibrary.Models
{
    /// <summary>
    /// Modélise un praticien.
    /// </summary>
    public class PraticienModel
    {
        #region Propriétés

        /// <summary>
        /// Numéro du praticien (id)
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Nom de famille du praticien
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Prénom du praticien
        /// </summary>
        public string Prenom { get; set; }

        /// <summary>
        /// Adresse du praticien
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Code Postal du praticien
        /// </summary>
        public string CodePostal { get; set; }

        /// <summary>
        /// Ville du praticien
        /// </summary>
        public string Ville { get; set; }

        /// <summary>
        /// Coefficient de notoriété du praticien
        /// </summary>
        public string CoeffNotoriete { get; set; }

        /// <summary>
        /// Type du praticien
        /// </summary>
        public TypePraticienModel TypePraticien { get; set; }

        /// <summary>
        /// Nom complet du praticien
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
