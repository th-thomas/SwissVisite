using MySqlConnector;
using System.Data;
using System.Data.SqlClient;

namespace SwissVisiteLibrary.DataAccess
{
    public abstract class BaseConnecteurSql
    {
        /// <summary>
        /// Le nom de la chaîne de connexion utilisée pour MySQL.
        /// </summary>
        protected const string chaineMySql = "mysql_swissvisite";

        /// <summary>
        /// Le nom de la chaîne de connexion utilisée pour SQL Server.
        /// </summary>
        protected const string chaineSqlServer = "sqlserver_swissvisite";

        /// <summary>
        /// Le type de serveur SQL utilisé par l'application
        /// </summary>
        private readonly ServeurSql serveurSql;

        /// <summary>
        /// Constructeur d'un connecteur SQL.
        /// Teste la connexion et lève éventuellement une exception.
        /// </summary>
        protected BaseConnecteurSql(ServeurSql typeServeurSql)
        {
            serveurSql = typeServeurSql;
            
            IDbConnection connexion = ConnexionBdd();

            try
            {
                connexion.Open();
            }
            catch (MySqlException)
            {
                connexion.Close();
                throw;
            }
            catch (SqlException)
            {
                connexion.Close();
                throw;
            }
        }

        /// <summary>
        /// Retourne une connexion à la base de données SQL
        /// </summary>
        /// <returns></returns>
        protected IDbConnection ConnexionBdd()
        {
            return (serveurSql == ServeurSql.SQLServer)
                ? (IDbConnection)new SqlConnection(GlobalConfig.GetChaineConnexion(chaineSqlServer))
                : new MySqlConnection(GlobalConfig.GetChaineConnexion(chaineMySql));
        }

        /// <summary>
        /// Types de serveurs SQL autorisés par l'application
        /// </summary>
        public enum ServeurSql
        {
            MySQL,
            SQLServer
        }
    }
}
