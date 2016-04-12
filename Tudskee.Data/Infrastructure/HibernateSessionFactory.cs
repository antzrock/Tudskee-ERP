using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tudskee.Data.Mappings;
using Tudskee.Entities;

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
                          .Database(MySQLConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey("tudskee_connection")))
                          .Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<IEntityBase>(new AutomappingConfiguration())))
                          .ExposeConfiguration(UpdateSchema)
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
                          .Database(MySQLConfiguration.Standard.ConnectionString(c => c.FromConnectionStringWithKey("tudskee_connection")))
                          .Mappings(m => m.AutoMappings.Add(AutoMap.AssemblyOf<IEntityBase>(new AutomappingConfiguration())))
                          .ExposeConfiguration(UpdateSchema)
                          .BuildSessionFactory();
                }
            }

            return _sessionFactory.OpenSession();
        }

        // Drops and creates the database schema
        private static void DropCreateSchema(Configuration cfg)
        {
            new SchemaExport(cfg)
                .Create(false, true);
        }

        // Updates the database schema if there are any changes to the model
        private static void UpdateSchema(Configuration cfg)
        {
            new SchemaUpdate(cfg);
        }
    }
}
