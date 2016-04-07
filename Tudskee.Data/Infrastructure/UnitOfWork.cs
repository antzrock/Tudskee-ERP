using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IHibernateSessionFactory _sessionFactory;
        private ITransaction _transaction;

        public ISession Session { get; private set; }

        public UnitOfWork(IHibernateSessionFactory sessionFactory)
        {
            this._sessionFactory = sessionFactory;
            this.Session = _sessionFactory.OpenSession();
        }

        public ISession GetSession()
        {
            return this.Session;
        }

        public void BeginTransaction()
        {
            _transaction = Session.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _transaction.Commit();
            }
            catch
            {
                _transaction.Rollback();
                throw;
            }
            finally
            {
                Session.Close();
            }
        }
    }
}
