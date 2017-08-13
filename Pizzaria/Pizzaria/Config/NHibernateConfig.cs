using System.IO;
using System.Web;
using NHibernate;
using NHibernate.Cfg;

namespace Pizzaria.Models.DAO
{
    public class NHibernateConfig
	{
        /// <summary>
        /// Abrir sessão para acesso ao banco de dados
        /// </summary>
        public static ISession OpenSession()
        {
	        var configuration = new Configuration();
	        var configurationPath = HttpContext.Current.Server.MapPath
		        (@"~\Config\nhibernate.configuration.xml");
	        configuration.Configure(configurationPath);
			string directoryPath = HttpContext.Current.Server.MapPath(@"~\Models\Hbm");
			configuration.AddDirectory(new DirectoryInfo(directoryPath));
			ISessionFactory sessionFactory = configuration.BuildSessionFactory();
	        return sessionFactory.OpenSession();
		}
    }
}

