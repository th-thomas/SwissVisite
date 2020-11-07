using SwissVisiteForm.Forms;
using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SwissVisite.Forms
{
    /// <summary>
    /// Formulaire permettant la saisie d'un nouveau
    /// rapport de visite et son enregistrement.
    /// </summary>
    public partial class NouveauRapportForm : Form
    {
        public delegate void FormHandler(string numeroRapport);
        public event FormHandler DemandeFermetureNouveauRapportForm_Event;


        #region Champs

        private readonly List<MedicamentModel> lesMedicaments;
        private readonly List<PraticienModel> lesPraticiens;

        private PraticienModel praticienSelectionne;

        private readonly Dictionary<MedicamentModel, int> echantillonsRenseignes;
        private readonly List<(MedicamentModel medicament, bool dispo)> medicamentsDispo;

        private readonly string chaineMotif = "Saisissez ici le motif de la visite...";
        private readonly string chaineBilan = "Saisissez ici le bilan de la visite...";

        #endregion


        #region Constructeur

        public NouveauRapportForm()
        {
            InitializeComponent();

            // Récupération des objets métier
            lesMedicaments = GlobalConfig.Connexion.MedicamentModel_GetAll();
            lesPraticiens = GlobalConfig.Connexion.PraticienModel_GetAll();

            /// Pour éviter que l'utilisateur, par inattention,
            /// n'enregistre son rapport avec le praticien par défaut
            /// (le premier praticien de la liste des praticiens),
            /// on ajoute à la liste un objet PraticienModel 'vide',
            /// qui sera le premier de la liste du ComboBox.
            /// A la vérification des données saisies,
            /// l'utilisateur sera ainsi notifié
            /// qu'il a oublié de renseigner le praticien.
            var pratNull = new PraticienModel();
            lesPraticiens.Insert(0, pratNull);

            // De même avec la liste des médicaments
            var medicNull = new MedicamentModel();

            medicamentsDispo = new List<(MedicamentModel medicament, bool dispo)>
            {
                (medicNull, true)
            };

            lesMedicaments.ForEach(m => medicamentsDispo.Add((m, true)));

            echantillonsRenseignes = new Dictionary<MedicamentModel, int>();

            pratVal.DisplayMember = "NomPrenom";
            pratVal.DataSource = lesPraticiens;

            praticienSelectionne = lesPraticiens.First();

            medicVal.DisplayMember = "NomCommercial";
            medicVal.DataSource = medicamentsDispo;

            dateVal.Value = DateTime.Now;

            ActiveControl = pratVal;
        }

        #endregion


        #region Méthodes

        /// <summary>
        /// Enregistre le rapport.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void enregistrerBtn_Click(object sender, EventArgs e)
        {
            RapportVisiteModel rapport = new RapportVisiteModel
            {
                Date = DateTime.Now,
                Praticien = praticienSelectionne,
                Motif = motifVal.Text,
                Bilan = bilanVal.Text,
                Visiteur = GlobalConfig.VisiteurConnecte,
                LesEchantillons = echantillonsRenseignes
            };

            GlobalConfig.Connexion.RapportVisite_Save(rapport);

            // TODO - Ouvrir le formulaire RapportsForm avec le rapport nouvellement créé
            DemandeFermetureNouveauRapportForm_Event?.Invoke(rapport.Numero);
        }

        /// <summary>
        /// L'utilisateur choisit de ne pas sauvegarder son rapport.
        /// Le formulaire retourne en mode Affichage
        /// si l'utilisateur confirme son intention ;
        /// sinon, l'édition continue.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void annulerBtn_Click(object sender, EventArgs e)
        {
            QuitterEditionForm qForm = new QuitterEditionForm();
            if (qForm.ShowDialog() != DialogResult.Cancel)
                DemandeFermetureNouveauRapportForm_Event?.Invoke(null);
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

            PraticiensForm praticienForm = new PraticiensForm(praticienSelectionne, true);
            praticienForm.PraticienEnvoyeEvent += PraticienForm_PraticienEnvoye;
            praticienForm.ShowDialog();
            praticienForm.PraticienEnvoyeEvent -= PraticienForm_PraticienEnvoye;
        }

        /// <summary>
        /// Change le praticien sélectionné à partir de celui
        /// choisi dans le PraticiensForm par l'utilisateur.
        /// </summary>
        /// <param name="p"></param>
        private void PraticienForm_PraticienEnvoye(PraticienModel p)
        {
            praticienSelectionne = p;
            pratVal.SelectedItem = p;
            pratVal.Text = p.NomPrenom;
        }

        private void motifVal_Enter(object sender, EventArgs e)
        {
            if (motifVal.Text == chaineMotif)
                motifVal.Text = "";
        }

        private void motifVal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(motifVal.Text))
                motifVal.Text = chaineMotif;

            VerifieFormComplet();
        }

        private void bilanVal_Enter(object sender, EventArgs e)
        {
            if (bilanVal.Text == chaineBilan)
                bilanVal.Text = "";
        }

        private void bilanVal_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(bilanVal.Text))
                bilanVal.Text = chaineBilan;

            VerifieFormComplet();
        }

        private void dateAujCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            dateVal.Value = DateTime.Now;
            dateVal.Enabled = (!dateAujCheckBox.Checked);
        }

        private void nombreEchantVal_ValueChanged(object sender, EventArgs e)
        {
            var medicBool = ((MedicamentModel medicament, bool dispo))medicVal.SelectedItem;
            MedicamentModel medicSelectionne = medicBool.medicament;
            ajouterEchantBtn.Enabled = (nombreEchantVal.Value > 0 && medicSelectionne.DepotLegal != null);
        }

        private void ajouterEchantBtn_Click(object sender, EventArgs e)
        {
            var medicBool = ((MedicamentModel medicament, bool dispo))medicVal.SelectedItem;
            MedicamentModel medicSelectionne = medicBool.medicament;

            // On ajoute l'échantillon à la ListView
            ListViewItem lvi = new ListViewItem(medicSelectionne.NomCommercial);
            lvi.SubItems.Add(nombreEchantVal.Value.ToString());
            echantListView.Items.Add(lvi);

            echantillonsRenseignes.Add(medicSelectionne, Convert.ToInt32(nombreEchantVal.Value));

            int i = 0;
            foreach (var (medicament, dispo) in medicamentsDispo)
            {

                if (medicament == medicSelectionne)
                    break;

                i++;
            }

            medicamentsDispo.Insert(i, (medicSelectionne, false));
            medicamentsDispo.RemoveAt(i + 1);

            medicVal.DataSource = medicamentsDispo.FindAll(m => m.dispo == true);
            medicVal.SelectedIndex = 0;

            nombreEchantVal.Value = 0;
        }

        private void supprimerEchantBtn_Click(object sender, EventArgs e)
        {
            ListViewItem ligne = echantListView.FocusedItem;
            if (ligne == null)
                return;

            echantListView.Items.Remove(ligne);

            MedicamentModel medicSupprime = lesMedicaments.Find(m => m.NomCommercial == ligne.Text);
            echantillonsRenseignes.Remove(medicSupprime);

            int i = 0;
            foreach (var (medicament, dispo) in medicamentsDispo)
            {

                if (medicament == medicSupprime)
                    break;

                i++;
            }

            medicamentsDispo.Insert(i, (medicSupprime, true));
            medicamentsDispo.RemoveAt(i + 1);

            medicVal.DataSource = medicamentsDispo.FindAll(m => m.dispo == true);
            medicVal.SelectedIndex = 0;
        }

        private void echantListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            supprimerEchantBtn.Enabled = (e.IsSelected);
        }

        private void medicVal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var medicBool = ((MedicamentModel medicament, bool dispo))medicVal.SelectedItem;
            MedicamentModel medicSelectionne = medicBool.medicament;

            ajouterEchantBtn.Enabled = (nombreEchantVal.Value > 0 && medicSelectionne.DepotLegal != null);
        }

        private void medicVal_Format(object sender, ListControlConvertEventArgs e)
        {
            var medicBool = ((MedicamentModel medicament, bool dispo))e.ListItem;
            e.Value = medicBool.medicament.NomCommercial ?? "";
        }

        private void pratVal_SelectionChangeCommitted(object sender, EventArgs e)
        {
            praticienSelectionne = (PraticienModel)pratVal.SelectedItem;
            pratVal.Text = praticienSelectionne.NomPrenom;

            pratDetailsBtn.Enabled = (praticienSelectionne.Numero != null);

            VerifieFormComplet();
        }

        private void VerifieFormComplet()
        {
            if (praticienSelectionne.Numero == null)
            {
                enregistrerBtn.Enabled = false;
                return;
            }
            
            if (string.IsNullOrWhiteSpace(motifVal.Text) || motifVal.Text == chaineMotif)
            {
                enregistrerBtn.Enabled = false;
                return;
            }

            if (string.IsNullOrWhiteSpace(bilanVal.Text) || bilanVal.Text == chaineBilan)
            {
                enregistrerBtn.Enabled = false;
                return;
            }

            enregistrerBtn.Enabled = true;
        }

        #endregion
    }
}
