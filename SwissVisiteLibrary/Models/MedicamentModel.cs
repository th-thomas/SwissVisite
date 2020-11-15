namespace SwissVisiteLibrary.Models
{
    /// <summary>
    /// Modélise un médicament GSB.
    /// </summary>
    public class MedicamentModel
    {
        #region Propriétés

        /// <summary>
        /// N° de dépôt légal du médicament
        /// </summary>
        public string DepotLegal { get; set; }

        /// <summary>
        /// Nom commercial du médicament
        /// </summary>
        public string NomCommercial { get; set; }

        /// <summary>
        /// Composition du médicament
        /// </summary>
        public string Composition { get; set; }

        /// <summary>
        /// Effets secondaires du médicament
        /// </summary>
        public string Effets { get; set; }

        /// <summary>
        /// Contre-indications du médicament
        /// </summary>
        public string ContreIndications { get; set; }

        /// <summary>
        /// Prix d'un échantillon du médicament
        /// </summary>
        public decimal? PrixEchantillon { get; set; }

        /// <summary>
        /// Famille du médicament
        /// </summary>
        public FamilleMedicModel Famille { get; set; }

        #endregion
    }
}
