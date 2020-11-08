using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SwissVisite.Forms
{
    public partial class ConnexionForm : Form
    {
        private readonly List<VisiteurModel> lesVisiteurs;

        public ConnexionForm()
        {
            InitializeComponent();

            lesVisiteurs = GlobalConfig.Connexion.VisiteurModel_GetAll();

            bordureHautPanel.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;
            titreFormLabel.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;

            identifiantVal.TextChanged += TextBox_TextChanged;
            motDePasseVal.TextChanged += TextBox_TextChanged;

            identifiantVal.Enter += IdentifiantVal_Enter;
            identifiantVal.Leave += IdentifiantVal_Leave;

            motDePasseVal.Enter += MotDePasseVal_Enter;
            motDePasseVal.Leave += MotDePasseVal_Leave;
        }

        private void MotDePasseVal_Leave(object sender, EventArgs e)
        {
            motDePasseValEffaceBtn.Enabled = motDePasseValEffaceBtn.Visible = false;
        }

        private void MotDePasseVal_Enter(object sender, EventArgs e)
        {
            motDePasseValEffaceBtn.Enabled = motDePasseValEffaceBtn.Visible = true;
        }

        private void IdentifiantVal_Leave(object sender, EventArgs e)
        {
            identifiantValEffaceBtn.Enabled = identifiantValEffaceBtn.Visible = false;
        }

        private void IdentifiantVal_Enter(object sender, EventArgs e)
        {
            identifiantValEffaceBtn.Enabled = identifiantValEffaceBtn.Visible = true;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {         
            connexionBtn.Enabled = !string.IsNullOrEmpty(identifiantVal.Text) && !string.IsNullOrEmpty(motDePasseVal.Text);
            erreurTextBox.Visible = false;
            erreurTextBox.Text = "";
        }

        private void quitterBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterMiniBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimMiniBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ControlePouvantDeplacerFenetre_MouseDown(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void connexionBtn_Click(object sender, EventArgs e)
        {            
            string identifiant = identifiantVal.Text;
            string motDePasse = motDePasseVal.Text;

            if (!lesVisiteurs.Exists(v => $"{ v.Prenom.First() }{ v.Nom }".ToLower() == identifiant))
            {
                identifiantVal.Text = "";
                motDePasseVal.Text = "";

                erreurTextBox.Visible = true;
                erreurTextBox.Text = "L'identifiant saisi n'est pas valide.";

                return;
            }

            if (!lesVisiteurs.Exists(v => v.DateEmbauche.ToString("ddMMyyyy") == motDePasseVal.Text))
            {
                motDePasseVal.Text = "";

                erreurTextBox.Visible = true;
                erreurTextBox.Text = "Le mot de passe saisi n'est pas valide.";

                return;
            }

            GlobalConfig.VisiteurConnecte = lesVisiteurs.Find(v => $"{ v.Prenom.First() }{ v.Nom }".ToLower() == identifiant);

            DialogResult = DialogResult.OK;

            Close();
        }

        private void identifiantValEffaceBtn_Click(object sender, EventArgs e)
        {
            identifiantVal.Text = "";
        }

        private void motDePasseValEffaceBtn_Click(object sender, EventArgs e)
        {
            motDePasseVal.Text = "";
        }
    }
}
