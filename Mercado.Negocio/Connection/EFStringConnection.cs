using System.Collections.Specialized;
using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace Mercado.Negocio.Connection
{

    /// <summary>
    /// Establece la cadena de conexión a utilizar por el EF. Datos estáticos y globales de la aplicación.
    /// </summary>
    public static class EFStringConnection
	{
		private static ConnectionStringSettings defaultConnection;

		/// <summary>
		/// Contiene los settings del App.config (sección "AppSettings")
		/// </summary>
		private static NameValueCollection AppSettings;  // configuraciones del App.config

		/// <summary>
		/// Contiene la cadena de conexión correspondiente al EF tomada del stringConnections.config
		/// </summary>
		private static readonly EntityConnectionStringBuilder EntityConnectionSB = new EntityConnectionStringBuilder();

		/// <summary>
		/// Inicializa la cadena de conexión apuntando a la BD Comunes.
		/// </summary>
		public static void InicializarConexion()
		{
			LoadConfig();
		}

		#region PROPIEDADES PUBLICAS

		/// <summary>
		/// Cadena de conexión tomada del stringConnection.config en el formato necesario para EF.
		/// </summary>
		public static string StringConnection
		{
			get
			{
				if (EntityConnectionSB.ConnectionString == null || EntityConnectionSB.ConnectionString == string.Empty)
				{
					LoadConfig();
				}
				return EntityConnectionSB.ConnectionString;
			}
		}

		/// <summary>
		/// Devuelve el Server correspondiente a la Cadena de Conexión actual.
		/// </summary>
		public static string Server
		{
			get
			{
				var stringConnection = StringConnection.Split(';').ToList();
				var cadenaConDataSource = stringConnection.Find(s => s.Contains("Server"));
				return cadenaConDataSource == null ? string.Empty : cadenaConDataSource.Split('=').Last().Split('"').First().ToUpper();
			}
		}

		/// <summary>
		/// Devuelve la Base de Datos correspondiente a la Cadena de Conexión actual.
		/// </summary>
		public static string BaseDeDatos
		{
			get
			{
				var stringConnection = StringConnection.Split(';').ToList();
				var cadenaInitialCatalog = stringConnection.Find(s => s.Contains("Database"));
				return cadenaInitialCatalog == null ? string.Empty : cadenaInitialCatalog.Split('=').Last();
			}
		}

		#endregion

		#region LOAD CONFIG

		/// <summary>
		/// Carga las configuraciones del App.config y stringConnections para armar la cadena de conexión.
		/// </summary>
		private static void LoadConfig()
		{
			// seccion AppSettings del app.config de la aplicación
			ConfigurationManager.RefreshSection("appSettings");
			AppSettings = ConfigurationManager.AppSettings;

			defaultConnection = ConfigurationManager.ConnectionStrings[EFStringConnection.GetClave("StringConnectionMercado")];
			EntityConnectionSB.ConnectionString = defaultConnection.ConnectionString;
		}

		/// <summary>
		/// Devuelve un string con la configuración correspondiente a la clave
		/// indicada. Busca la clave dentro de la sección "appSettings" de App.config
		/// </summary>
		public static string GetClave(string key)
		{
			return AppSettings != null ? AppSettings[key] : string.Empty;
		}

		#endregion


		#region ANALISIS de QUERYs

		/// <summary>
		/// Devuelve el query en formato EF SQL correspondiente a una consulta LinQ.
		/// </summary>
		/// <param name="query">Query a analizar (sin materializar).</param>
		/// <returns>Un string que representa el comando a ejecutar a través del data source.</returns>
		public static string GetTraceSQL(IQueryable query)
		{
			return ((ObjectQuery)query).ToTraceString();
		}

		#endregion

	}
}