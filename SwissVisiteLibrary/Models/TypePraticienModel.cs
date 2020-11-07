namespace SwissVisiteLibrary.Models
{
    /// <summary>
    /// Modélise un type de praticien.
    /// </summary>
    public class TypePraticienModel
    {
        #region Propriétés

        /// <summary>
        /// Code du type de praticien
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Libellé du type de praticien
        /// </summary>
        public string Libelle { get; set; }

        /// <summary>
        /// Lieu d'exercice du type de praticien
        /// </summary>
        public string Lieu { get; set; }

        #endregion
    }
}
