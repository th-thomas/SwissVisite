using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SwissVisite.Forms;
using SwissVisiteForm.Forms;
using SwissVisiteLibrary;
using SwissVisiteLibrary.Models;

namespace SwissVisite
{
    /// <summary>
    /// Le formulaire principal de l'application. Il permet d'ouvrir les formulaires enfants,
    /// qui viennent s'ancrer dans ce formulaire parent.
    /// Ainsi, l'utilisateur ne verra toujours qu'une seule fenêtre à l'écran.
    /// </summary>
    public partial class MainForm : Form
    {
        #region Champs

        /// <summary>
        /// Une petite bordure qui permet de mettre en évidence
        /// le bouton du formulaire enfant actuellement ouvert.
        /// </summary>
        private readonly Panel formEnfantFocusPanel;
        private IconButton boutonSelectionne;
        
        private Form formEnfantOuvert;
        private bool peutQuitterFormEnfantSansConfirmation;

        #endregion


        #region Constructeur

        public MainForm()
        {
            InitializeComponent();

            // Le visiteur connecté est accueilli par un message personnalisé
            // et l'application affiche son identité (prénom nom).
            VisiteurModel visiteurConnecte = GlobalConfig.VisiteurConnecte;
            string visiteurConnectePrenomNom = $"{ visiteurConnecte.Prenom } { visiteurConnecte.Nom }";
            visiteurConnecteLabel.Text = visiteurConnectePrenomNom;
            titreMessageAccueilLabel.Text = $"Bienvenue, { visiteurConnectePrenomNom } !";

            formEnfantFocusPanel = new Panel
            {
                Size = new Size(7, 66),
            };

            peutQuitterFormEnfantSansConfirmation = true;

            menuPanel.Controls.Add(formEnfantFocusPanel);

            titreFormEnfantPanel.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;
            titreFormEnfantLabel.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;
            titreFormEnfantPicBox.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;
            visiteurConnecteLabel.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;
            menuPanel.MouseDown += ControlePouvantDeplacerFenetre_MouseDown;

            rapportsBtn.Click += BoutonMenu_Click;
            medicamentsBtn.Click += BoutonMenu_Click;
            praticiensBtn.Click += BoutonMenu_Click;
            visiteursBtn.Click += BoutonMenu_Click;

            quitterBtn.Click += QuitterBtn_Click;
            quitterMiniBtn.Click += QuitterBtn_Click;
        }

        #endregion


        #region Méthodes

        /// <summary>
        /// Rend "actif" (met en valeur) le bouton du formulaire enfant
        /// sélectionné par l'utilisateur dans le menu principal.
        /// </summary>
        /// <param name="senderBtn">Le bouton sélectionné.</param>
        private void ActiverBouton(object senderBtn)
        {
            if (senderBtn == null)
                return;
           
            // "Désactivation" du bouton précédemment sélectionné
            DesactiverBouton();
            // "Activation" (mise en avant) du bouton sélectionné
            boutonSelectionne = (IconButton)senderBtn;
            boutonSelectionne.BackColor = Color.SteelBlue;
            boutonSelectionne.ForeColor = Color.White;
            boutonSelectionne.TextAlign = ContentAlignment.MiddleCenter;
            boutonSelectionne.IconColor = Color.White;
            boutonSelectionne.TextImageRelation = TextImageRelation.TextBeforeImage;
            boutonSelectionne.ImageAlign = ContentAlignment.MiddleRight;
            // Petite bordure à gauche du bouton sélectionné
            formEnfantFocusPanel.Location = new Point(0, boutonSelectionne.Location.Y);
            formEnfantFocusPanel.Visible = true;
            formEnfantFocusPanel.BackColor = Color.White;
            formEnfantFocusPanel.BringToFront();
            // Barre de titre du formulaire sélectionné
            titreFormEnfantPicBox.IconChar = boutonSelectionne.IconChar;
            titreFormEnfantLabel.Text = boutonSelectionne.Text;
        }

        /// <summary>
        /// Rend un bouton "inactif".
        /// </summary>
        private void DesactiverBouton() 
        {
            if (boutonSelectionne == null)
                return;
            
            boutonSelectionne.BackColor = Color.DodgerBlue;
            boutonSelectionne.ForeColor = Color.White;
            boutonSelectionne.TextAlign = ContentAlignment.MiddleLeft;
            boutonSelectionne.IconColor = Color.White;
            boutonSelectionne.TextImageRelation = TextImageRelation.ImageBeforeText;
            boutonSelectionne.ImageAlign = ContentAlignment.MiddleLeft;
        }

        /// <summary>
        /// Ouvre le formulaire enfant et l'ancre dans le formulaire principal.
        /// </summary>
        /// <param name="formEnfant">Le formulaire enfant à ouvrir.</param>
        private void OuvrirFormEnfant(Form formEnfant)
        {
            // Un seul formulaire peut être ouvert :
            // on ferme le formulaire précédemment sélectionné
            if (formEnfantOuvert != null)
                formEnfantOuvert.Close();

            formEnfantOuvert = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            enfantPanel.Controls.Add(formEnfant);
            enfantPanel.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }

        private void BoutonMenu_Click(object sender, EventArgs e)
        {
            if (!FormEnfantAutoriseQuitter())
                return;

            ActiverBouton(sender);

            var monSender = (IconButton)sender;

            if (monSender == rapportsBtn)
            {
                RapportsForm rForm = new RapportsForm();
                rForm.DemandeOuvertureNouveauRapportForm_Event += RForm_DemandeOuvertureNouveauRapportForm_Event;
                OuvrirFormEnfant(rForm);          
            }

            else
            {
                Form form;

                if (monSender == medicamentsBtn)
                    form = new MedicsForm();
                else if (monSender == visiteursBtn)
                    form = new VisiteursForm();
                else
                    form = new PraticiensForm();

                OuvrirFormEnfant(form);
            } 
        }

        private void RForm_DemandeOuvertureNouveauRapportForm_Event(object sender)
        {
            NouveauRapportForm nForm = new NouveauRapportForm();
            nForm.DemandeFermetureNouveauRapportForm_Event += NForm_DemandeFermetureNouveauRapportForm_Event;
            peutQuitterFormEnfantSansConfirmation = false;
            OuvrirFormEnfant(nForm);
        }

        private void NForm_DemandeFermetureNouveauRapportForm_Event(string numeroRapport)
        {
            RapportsForm rForm = new RapportsForm(numeroRapport);
            rForm.DemandeOuvertureNouveauRapportForm_Event += RForm_DemandeOuvertureNouveauRapportForm_Event;
            peutQuitterFormEnfantSansConfirmation = true;
            OuvrirFormEnfant(rForm);
        }

        private bool FormEnfantAutoriseQuitter()
        {
            bool output;

            if (peutQuitterFormEnfantSansConfirmation)
                output = true;
            
            else
            {
                QuitterEditionForm qForm = new QuitterEditionForm();
                qForm.ShowDialog();
                var resultat = qForm.DialogResult;

                if (resultat == DialogResult.Cancel)
                   output = false;
                else
                {
                    peutQuitterFormEnfantSansConfirmation = true;
                    output = true;
                }
            }

            return output;
        }

        private void QuitterBtn_Click(object sender, EventArgs e)
        {
            object monSender = (sender == quitterMiniBtn) ? quitterBtn : sender;
            
            if (boutonSelectionne == null)
            {
                ActiverBouton(monSender);
                QuitterForm quitterForm = new QuitterForm();
                quitterForm.ShowDialog();
                DesactiverBouton();
                formEnfantFocusPanel.Visible = false;
                titreFormEnfantPicBox.IconChar = IconChar.Home;
                titreFormEnfantLabel.Text = "Accueil";
            }

            else
            {
                // On sauvegarde l'ancien bouton :
                // Si l'utilisateur ne veut finalement pas quitter l'application,
                // on réactive le bouton du formulaire enfant resté ouvert
                IconButton ancienBouton = boutonSelectionne;
                ActiverBouton(monSender);
                QuitterForm quitterForm = new QuitterForm();
                quitterForm.ShowDialog();
                ActiverBouton(ancienBouton);
            }
        }

        private void MinimiserBtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        // On utilise des fonctions tirées des bibliothèques (DLL) de Windows,
        // afin de permettre à l'utilisateur de déplacer le formulaire sur l'écran
        // grâce au déplacement de la souris lorsque le clic gauche est maintenu
        // sur certains éléments graphiques du formulaire.
        // (En effet, on n'utilise pas la bordure de fenêtre classique.)

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ControlePouvantDeplacerFenetre_MouseDown(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
