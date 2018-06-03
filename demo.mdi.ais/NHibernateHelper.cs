using demo.mdi.ais.Helpers.ORMInteraction;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.mdi.ais
{
    public class NHibernateHelper
    {
        public static ISession OpenSession()
        {
            var configuration = new Configuration();
            var configurePath = (@"hibernate.cfg.xml");
            configuration.Configure(configurePath);
            configuration.AddAssembly(typeof(District).Assembly);
            ISessionFactory sessionFactory = configuration.BuildSessionFactory();
            new SchemaUpdate(configuration).Execute(true, true);
            return sessionFactory.OpenSession();
        }
    }
}
