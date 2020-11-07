using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SwissVisite.Forms
{
    public partial class VisiteursForm : Form
    {
        #region Champs

        private readonly List<VisiteurModel> lesVisiteurs;
        private VisiteurModel visiteurSelectionne;

        #endregion


        #region Constructeurs

        public VisiteursForm()
        {
            InitializeComponent();

            lesVisiteurs = GlobalConfig.Connexion.VisiteurModel_GetAll();

            if (!lesVisiteurs.Any())
            {
                MessageBox.Show("Aucun visiteur dans la base de données.");
                this.Enabled = false;
                return;
            }

            visiteurSelectionne = new VisiteurModel();

            visitSelecComboBox.DisplayMember = "NomPrenom";
            visitSelecComboBox.DataSource = lesVisiteurs;
        }

        #endregion


        #region Méthodes

        private void ActualiserFormulaire()
        {
            ActiveControl = null;

            visiteurSelectionne = (VisiteurModel)visitSelecComboBox.SelectedItem;

            nomVal.Text = visiteurSelectionne.Nom;
            prenomVal.Text = visiteurSelectionne.Prenom;
            adresseVal.Text = visiteurSelectionne.Adresse;
            villeVal.Text = $"{ visiteurSelectionne.CodePostal} { visiteurSelectionne.Ville }";
            secteurVal.Text = "(Non renseigné)";
            laboVal.Text = "(Non renseigné)";

            // Grise éventuellement un des boutons Suivant / Précédent
            visitPrecBtn.Enabled = visitSelecComboBox.SelectedIndex != 0;
            visitSuivBtn.Enabled = visitSelecComboBox.SelectedIndex != visitSelecComboBox.Items.Count - 1;
        }

        private void visitPrecBtn_Click(object sender, EventArgs e)
        {
            if (visitSelecComboBox.SelectedIndex > 0)
            {
                --visitSelecComboBox.SelectedIndex;
            }
        }

        private void visitSuivBtn_Click(object sender, EventArgs e)
        {
            if (visitSelecComboBox.SelectedIndex < visitSelecComboBox.Items.Count - 1)
            {
                ++visitSelecComboBox.SelectedIndex;
            }
        }

        private void visitSelecComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualiserFormulaire();
        }

        #endregion
    }
}
