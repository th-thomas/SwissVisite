using System;
using SwissVisiteLibrary.DataAccess;
using SwissVisiteLibrary.Models;
using System.Configuration;
using System.Diagnostics;

namespace SwissVisiteLibrary
{
    /// <summary>
    /// Point d'entrée pour la connexion à la source de données (SGBDR, fichiers texte...).
    /// On y trouve aussi l'utilisateur courant de l'application.
    /// </summary>
    public static class GlobalConfig
    {
        /// <summary>
        /// Connexion à la source de données retenue par l'application.
        /// </summary>
        public static ISwissCrud Connexion { get; private set; }

        /// <summary>
        /// L'utilisateur courant de l'application.
        /// </summary>
        public static VisiteurModel VisiteurConnecte { get; set; }

        /// <summary>
        /// Initialise la connexion à la source de données.
        /// </summary>
        public static void InitialiserConnexion()
        {
            string sourceDonnees = ConfigurationManager.AppSettings["sourceDonnees"];            
            string proceduresStockees = ConfigurationManager.AppSettings["proceduresStockees"];

            // Par défaut on utilise MySQL
            var typeServeur = (sourceDonnees == "sqlserver")
                ? BaseConnecteurSql.ServeurSql.SQLServer
                : BaseConnecteurSql.ServeurSql.MySQL;

            // Par défaut on utilise les procédures stockées
            Connexion = (proceduresStockees == "non")
                ? (ISwissCrud)new ConnecteurSqlStandard(typeServeur)
                : new ConnecteurSqlProceduresStockees(typeServeur);
        }

        /// <summary>
        /// Obtient la chaîne de connexion dans le fichier app.config
        /// </summary>
        /// <param name="nom">Le nom de la chaîne de connexion.</param>
        /// <returns></returns>
        public static string GetChaineConnexion(string nom)
        {
            return ConfigurationManager.ConnectionStrings[nom].ConnectionString;
        }
    }
}
