namespace SwissVisiteLibrary.Models
{
    /// <summary>
    /// Modélise une famille de médicaments GSB.
    /// </summary>
    public class FamilleMedicModel
    {
        #region Propriétés

        /// <summary>
        /// Code de la famille de médicaments
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Libellé de la famille de médicaments
        /// </summary>
        public string Libelle { get; set; }

        #endregion Propriétés
    }
}
