using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tudskee.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        ISession GetSession();
        void BeginTransaction();
        void Commit();
    }
}
