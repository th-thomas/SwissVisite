using SwissVisite.Forms;
using SwissVisiteLibrary;
using System;
using System.Windows.Forms;

namespace SwissVisite
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                GlobalConfig.InitialiserConnexion();
            }
            catch (Exception ex)
            {
                string message = "";

                message += ex.Message + "\n\n";

                Exception inner = ex.InnerException;
                while (inner != null)
                {
                    message += inner.Message + "\n\n";
                    inner = inner.InnerException;
                }

                MessageBox.Show(message, "Erreur lors de la connexion à la base de données.");

                Environment.Exit(0);
            }

            //// Raccourci permettant de se connecter automatiquement avec un utilisateur pré-défini (peut être utile pendant la phase de développement)
            //GlobalConfig.VisiteurConnecte = GlobalConfig.Connexion.VisiteurModel_GetAll().Find(v => v.Matricule.ToLower() == "a17");
            //Application.Run(new MainForm());
            //// (Si utilisé, il faut alors commenter les lignes suivantes)

            ConnexionForm cForm = new ConnexionForm();

            if (cForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
