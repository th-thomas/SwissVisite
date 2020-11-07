using SwissVisite.Forms;
using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SwissVisiteForm.Forms
{
    public partial class RapportsForm : Form
    {
        public delegate void FormHandler(object sender);
        public event FormHandler DemandeOuvertureNouveauRapportForm_Event;

        #region Champs

        /// <summary>
        /// Le visiteur connecté à l'application.
        /// </summary>
        private readonly VisiteurModel visiteurConnecte;
        /// <summary>
        /// Liste des rapports du visiteur connecté à l'application.
        /// </summary>
        private readonly List<RapportVisiteModel> lesRapports;

        /// <summary>
        /// Le rapport actuellement sélectionné pour l'affichage.
        /// </summary>
        private RapportVisiteModel rapportSelectionne = new RapportVisiteModel();
        /// <summary>
        /// Le praticien actuellement sélectionné
        /// </summary>
        private PraticienModel praticienSelectionne = new PraticienModel();


        /// <summary>
        /// Cette variable permet d'éviter d'actualiser deux fois les données affichées lorsque
        /// l'événement SelectionChangeCommited est lancé.
        /// </summary>
        private bool activerEventIndexChanged = true;
       
        #endregion


        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut.
        /// </summary>
        public RapportsForm(string numeroDernierRapportCree = null)
        {
            InitializeComponent();

            // Récupération des objets métier
            visiteurConnecte = GlobalConfig.VisiteurConnecte;
            lesRapports = GlobalConfig.Connexion.RapportVisiteModel_GetByVisiteur(visiteurConnecte);

            if (!lesRapports.Any())
            {
                MessageBox.Show("Aucun rapport dans la base de données.");
                mainContainer.Panel1.Enabled = false;
                panelDroiteSplit.Panel1.Enabled = false;
                subPanelDroite.Panel1.Enabled = false;
                subPanelDroite.Panel2.Enabled = true;
                return;
            }

            rapportSelecComboBox.DisplayMember = "Numero";
            rapportSelecComboBox.DataSource = lesRapports;
            rapportSelectionne = (numeroDernierRapportCree == null) ? lesRapports.First() : lesRapports.Find(r => r.Numero == numeroDernierRapportCree);
            rapportSelecComboBox.SelectedItem = rapportSelectionne;

            ActualiserFormulaire();

            rapportSelecComboBox.SelectionChangeCommitted += rapportSelecComboBox_SelectionChangeCommitted;
            // Important : souscrire seulement à ce moment !
            rapportSelecComboBox.SelectedIndexChanged += rapportSelecComboBox_SelectedIndexChanged;
        }

        #endregion


        #region Méthodes

        /// <summary>
        /// Actualise les données affichées dans le formulaire
        /// à partir du rapport sélectionné.
        /// </summary>
        private void ActualiserFormulaire()
        {
            ActiveControl = null;

            echantListView.Items.Clear();

            // Affichage des données du rapport de visite (sans les échantillons).
            idVal.Text = rapportSelectionne.Numero;
            praticienSelectionne = rapportSelectionne.Praticien;
            pratVal.Text = praticienSelectionne.NomPrenom;
            dateVal.Text = rapportSelectionne.Date.ToString("D");
            motifVal.Text = rapportSelectionne.Motif;
            bilanVal.Text = rapportSelectionne.Bilan;

            // Affichage des échantillons
            // (couples de médicament + nombre d'échantillons proposés),
            // dans une ListView.
            foreach (KeyValuePair<MedicamentModel, int> echantillon in rapportSelectionne.LesEchantillons)
            {
                ListViewItem lvi = new ListViewItem(echantillon.Key.NomCommercial);
                lvi.SubItems.Add(echantillon.Value.ToString());

                echantListView.Items.Add(lvi);
            }

            // Grise éventuellement un des boutons Suivant / Précédent (en bout de liste)
            rappPrecBtn.Enabled = rapportSelecComboBox.SelectedIndex != 0;
            rappSuivBtn.Enabled = rapportSelecComboBox.SelectedIndex != rapportSelecComboBox.Items.Count - 1;
        }

        /// <summary>
        /// Change le texte de rapportSelecComboBox pour afficher
        /// la date du rapport et le nom et le prénom du praticien concerné.
        /// On évite ainsi de créer une propriété superflue
        /// dans la classe RapportVisiteModel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rapportSelecComboBox_Format(object sender, ListControlConvertEventArgs e)
        {
            string date = ((RapportVisiteModel)e.ListItem).Date.ToString("d");
            string nomPrenom = ((RapportVisiteModel)e.ListItem).Praticien.NomPrenom;
            e.Value = $"{ date }, { nomPrenom }";
        }


        /// <summary>
        /// Affiche l'annuaire des praticiens en l'ouvrant
        /// directement à l'entrée du praticien sélectionné.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pratDetailsBtn_Click(object sender, EventArgs e)
        {
            if (praticienSelectionne.Numero == null)
                return;

            PraticiensForm praticienForm = new PraticiensForm(praticienSelectionne, false);
            praticienForm.ShowDialog();
        }

        /// <summary>
        /// L'utilisateur choisit le rapport précédent dans la liste.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rappPrecBtn_Click(object sender, EventArgs e)
        {
            if (rapportSelecComboBox.SelectedIndex > 0)
                --rapportSelecComboBox.SelectedIndex;
        }

        /// <summary>
        /// L'utilisateur choisit le rapport suivant dans la liste.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rappSuivBtn_Click(object sender, EventArgs e)
        {
            if (rapportSelecComboBox.SelectedIndex < rapportSelecComboBox.Items.Count - 1)
                ++rapportSelecComboBox.SelectedIndex;
        }

        /// <summary>
        /// L'utilisateur sélectionne un rapport différent directement dans la liste
        /// (directement depuis la ComboBox).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rapportSelecComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            rapportSelectionne = (RapportVisiteModel)rapportSelecComboBox.SelectedItem;
            ActualiserFormulaire();
            activerEventIndexChanged = false;
        }

        /// <summary>
        /// Le rapport sélectionné dans la ComboBox a changé (par l'utilisateur / de façon programmatique).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rapportSelecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activerEventIndexChanged)
            {
                rapportSelectionne = (RapportVisiteModel)rapportSelecComboBox.SelectedItem;
                ActualiserFormulaire();
            }

            else
                activerEventIndexChanged = true;
        }

        private void nouveauBtn_Click(object sender, EventArgs e)
        {
            DemandeOuvertureNouveauRapportForm_Event?.Invoke(this);
        }

        #endregion

    }
}
