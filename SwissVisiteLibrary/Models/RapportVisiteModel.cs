using System;
using System.Collections.Generic;

namespace SwissVisiteLibrary.Models
{
    /// <summary>
    /// Modélise un rapport de visite (compte-rendu).
    /// </summary>
    public class RapportVisiteModel
    {
        #region Propriétés

        /// <summary>
        /// Numéro du rapport de visite
        /// </summary>
        public string Numero { get; set; }

        /// <summary>
        /// Date de la visite
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Bilan de la visite
        /// </summary>
        public string Bilan { get; set; }

        /// <summary>
        /// Motif de la visite
        /// </summary>
        public string Motif { get; set; }

        /// <summary>
        /// Praticien visité
        /// </summary>
        public PraticienModel Praticien { get; set; }

        /// <summary>
        /// Visiteur en charge de la visite et du rapport
        /// </summary>
        public VisiteurModel Visiteur { get; set; }

        /// <summary>
        /// Echantillons de médicaments présentés lors de la visite
        /// </summary>
        public Dictionary<MedicamentModel, int> LesEchantillons { get; set; }

        #endregion
    }
}
