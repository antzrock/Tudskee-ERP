using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Data.Infrastructure
{
    public class HibernateSessionFactory : IHibernateSessionFactory
    {
        private static ISessionFactory _sessionFactory;

        static readonly object factorylock = new object();

        public HibernateSessionFactory()
        {
            lock (factorylock)
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                          .Database(MySQLConfiguration.Standard.ConnectionString("tudskee_connection"))
                          .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                          .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
                          .BuildSessionFactory();
                }
            }
        }

        public ISession OpenSession()
        {
            lock (factorylock)
            {
                if (_sessionFactory == null)
                {
                    _sessionFactory = Fluently.Configure()
                          .Database(MySQLConfiguration.Standard.ConnectionString("tudskee_connection"))
                          .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
                          .ExposeConfiguration(config => new SchemaUpdate(config).Execute(false, true))
                          .BuildSessionFactory();
                }
            }

            return _sessionFactory.OpenSession();
        }
    }
}
