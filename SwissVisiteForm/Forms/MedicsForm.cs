using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SwissVisite.Forms
{
    public partial class MedicsForm : Form
    {
        #region Champs

        private readonly List<MedicamentModel> lesMedicaments;
        private readonly List<FamilleMedicModel> lesFamilles;
        private List<MedicamentModel> medicamentsDispos;
        private MedicamentModel medicamentSelectionne;
        private FamilleMedicModel familleSelectionnee;

        #endregion


        #region Constructeurs

        public MedicsForm()
        {
            InitializeComponent();

            triTousRadioBtn.Click += triRadioButtons_Click;
            triParFamilleRadioBtn.Click += triRadioButtons_Click;

            lesMedicaments = GlobalConfig.Connexion.MedicamentModel_GetAll();
            lesFamilles = GlobalConfig.Connexion.FamilleMedicModel_GetAll();

            if (!lesMedicaments.Any())
            {
                MessageBox.Show("Aucun médicament dans la base de données.");
                this.Enabled = false;
                return;
            }

            medicamentsDispos = new List<MedicamentModel>(lesMedicaments);
            medicSelecComboBox.DisplayMember = "NomCommercial";
            medicSelecComboBox.DataSource = medicamentsDispos;

            ActualiserFormulaire();
        }

        #endregion


        #region Méthodes

        private void ActualiserFormulaire()
        {
            ActiveControl = null;

            medicamentSelectionne = (MedicamentModel)medicSelecComboBox.SelectedItem;

            // Certaines familles peuvent ne pas comporter de médicament
            if (medicamentsDispos.Count == 0)
            {
                codeVal.Text = "";
                nomCommVal.Text = "(Aucun médicament dans cette famille)";
                familleVal.Text = "";
                composVal.Text = "";
                effetsVal.Text = "";
                contreIndicVal.Text = "";
                prixEchantVal.Text = "";
            }

            else
            {
                codeVal.Text = medicamentSelectionne.DepotLegal;
                nomCommVal.Text = medicamentSelectionne.NomCommercial;
                familleVal.Text = medicamentSelectionne.Famille.Libelle;
                composVal.Text = medicamentSelectionne.Composition;
                effetsVal.Text = medicamentSelectionne.Effets;
                contreIndicVal.Text = medicamentSelectionne.ContreIndications;
                prixEchantVal.Text = medicamentSelectionne.PrixEchantillon.ToString("C");

                // Grise éventuellement un des boutons Suivant / Précédent
                medicPrecBtn.Enabled = medicSelecComboBox.SelectedIndex != 0;
                medicSuivBtn.Enabled = medicSelecComboBox.SelectedIndex != medicSelecComboBox.Items.Count - 1;
            }
        }

        private void triRadioButtons_Click(object sender, EventArgs e)
        {
            if (sender == triParFamilleRadioBtn)
            {
                familleSelecComboBox.Visible = true;
                familleSelecComboBox.DisplayMember = "Libelle";
                familleSelecComboBox.DataSource = lesFamilles;
                
                familleSelectionnee = (FamilleMedicModel)familleSelecComboBox.SelectedItem;
                medicamentsDispos = lesMedicaments.Where(m => m.Famille.Code == familleSelectionnee.Code).ToList();
            }
            
            else
            {
                familleSelecComboBox.Visible = false;
                medicamentsDispos = lesMedicaments;
            }

            medicSelecComboBox.DisplayMember = "NomCommercial";
            medicSelecComboBox.DataSource = medicamentsDispos;

            ActualiserFormulaire();
        }

        private void medicPrecBtn_Click(object sender, EventArgs e)
        {
            if (medicSelecComboBox.SelectedIndex > 0)
                --medicSelecComboBox.SelectedIndex;

            ActualiserFormulaire();
        }

        private void medicSuivBtn_Click(object sender, EventArgs e)
        {
            if (medicSelecComboBox.SelectedIndex < medicSelecComboBox.Items.Count - 1)
                ++medicSelecComboBox.SelectedIndex;

            ActualiserFormulaire();
        }

        private void familleSelecComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            familleSelectionnee = (FamilleMedicModel)familleSelecComboBox.SelectedItem;
            medicamentsDispos = lesMedicaments.Where(m => m.Famille.Code == familleSelectionnee.Code).ToList();
            medicSelecComboBox.DataSource = medicamentsDispos;

            ActualiserFormulaire();
        }

        private void medicSelecComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ActualiserFormulaire();
        }

        #endregion
    }
}
