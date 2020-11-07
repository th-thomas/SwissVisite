using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SwissVisite.Forms
{
    public partial class PraticiensForm : Form
    {
        public delegate void PraticienHandler (PraticienModel p);
        public event PraticienHandler PraticienEnvoyeEvent;

        #region Champs 

        private readonly List<PraticienModel> lesPraticiens = GlobalConfig.Connexion.PraticienModel_GetAll();
        private PraticienModel praticienSelectionne = new PraticienModel();
        /// <summary>
        /// On attribuera false temporairement à cette variable,
        /// pour éviter de déclencher les actions de deux événements (SelectedItemChanged et SelectedIndexChanged)
        /// lorsque l'item sélectionné est changé par l'utilisateur dans le combobox du Praticien.
        /// Sans cela on appellerait deux fois la méthode ActualiserFormulaire() lors du changement de Praticien sélectionné
        /// directement depuis la ComboBox (sans les boutons Préc. / Suiv.)
        /// </summary>
        private bool activerEventIndexChanged = true;

        #endregion


        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut.
        /// Le praticien dont les détails sont taffichés
        /// est le premier de la liste des praticiens.
        /// </summary>
        public PraticiensForm()
        {
            InitializeComponent();

            pratSelecComboBox.DisplayMember = "NomPrenom";
            pratSelecComboBox.DataSource = lesPraticiens;

            if (!lesPraticiens.Any())
            {
                MessageBox.Show("Aucun praticien dans la base de données.");
                this.Enabled = false;
                return;
            }

            praticienSelectionne = lesPraticiens.First();

            ActualiserFormulaire();

            pratSelecComboBox.SelectedIndexChanged += pratSelecCombobox_SelectedIndexChanged;
        }

        /// <summary>
        /// Constructeur à destination d'un formulaire tiers.
        /// A l'ouverture, PraticiensForms affiche directement
        /// les détails du praticien particulier
        /// requis par le formulaire tiers.
        /// </summary>
        /// <param name="praticien">Le praticien dont les détails doivent être affichés.</param>
        /// <param name="tiersAttendPraticienEnRetour">Le formulaire tiers demande ou non
        /// un objet Praticien à la fermeture de PraticiensForm.</param>
        public PraticiensForm(PraticienModel praticien, bool tiersAttendPraticienEnRetour)
        {
            InitializeComponent();

            Padding = new Padding(1);

            // Si le formulaire tiers attend un objet Praticien à la fermeture de PraticiensForm,
            // on affiche un bouton de Sélection du praticien en plus du bouton Retour.
            // Sinon, on affiche seulement le bouton Retour.
            retourBtn.Visible = true;

            if (tiersAttendPraticienEnRetour)
                selecBtn.Visible = true;

            else
            {
                selecBtn.Visible = false;
                pratSelecLabel.Visible = false;
                pratPrecBtn.Visible = false;
                pratSuivBtn.Visible = false;
                pratSelecComboBox.Visible = false;
                // On recentre le bouton de retour, puisqu'il est maintenant le seul visible.
                retourBtn.Left = (retourBtn.Parent.Width - retourBtn.Width) / 2;
                retourBtn.Top = (retourBtn.Parent.Height - retourBtn.Height) / 2;
            }

            pratSelecComboBox.DisplayMember = "NomPrenom";
            pratSelecComboBox.DataSource = lesPraticiens;
            pratSelecComboBox.SelectedIndexChanged += pratSelecCombobox_SelectedIndexChanged;

            pratSelecComboBox.SelectedIndex = lesPraticiens.FindIndex(p => p.Numero == praticien.Numero);

            // Nécessaire dans le cas où le praticien requis s'avère être le premier de la liste.
            // L'index sélectionné par défaut étant 0, il faut déclencher manuellement l'événement SelectedIndexChanged.
            if (pratSelecComboBox.SelectedIndex == 0) pratSelecCombobox_SelectedIndexChanged(this, EventArgs.Empty);
        }

        #endregion


        #region Méthodes

        private void ActualiserFormulaire()
        {
            ActiveControl = null;

            idVal.Text = praticienSelectionne.Numero;
            nomVal.Text = praticienSelectionne.Nom;
            prenomVal.Text = praticienSelectionne.Prenom;
            adresseVal.Text = praticienSelectionne.Adresse;
            villeVal.Text = $"{ praticienSelectionne.CodePostal } { praticienSelectionne.Ville }";
            coeffNotVal.Text = praticienSelectionne.CoeffNotoriete;
            lieuExerciceVal.Text = praticienSelectionne.TypePraticien.Lieu;

            // Grise éventuellement un des boutons Suivant / Précédent
            pratPrecBtn.Enabled = pratSelecComboBox.SelectedIndex != 0;
            pratSuivBtn.Enabled = pratSelecComboBox.SelectedIndex != pratSelecComboBox.Items.Count - 1;
        }

        private void selecBtn_Click(object sender, EventArgs e)
        {
            PraticienEnvoyeEvent?.Invoke(praticienSelectionne);
            Close();
        }

        private void pratPrecBtn_Click(object sender, EventArgs e)
        {
            if (pratSelecComboBox.SelectedIndex > 0)
                --pratSelecComboBox.SelectedIndex;
        }

        private void pratSuivBtn_Click(object sender, EventArgs e)
        {
            if (pratSelecComboBox.SelectedIndex < pratSelecComboBox.Items.Count - 1)
                ++pratSelecComboBox.SelectedIndex;
        }

        private void pratSelecCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activerEventIndexChanged)
            {
                praticienSelectionne = (PraticienModel)pratSelecComboBox.SelectedItem;
                ActualiserFormulaire();
            }

            else
                activerEventIndexChanged = true;
        }

        private void pratSelecComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            praticienSelectionne = (PraticienModel)pratSelecComboBox.SelectedItem;
            ActualiserFormulaire();
            activerEventIndexChanged = false;
        }

        #endregion 
    }
}
