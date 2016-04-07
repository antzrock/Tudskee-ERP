using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tudskee.Data.Infrastructure;
using Tudskee.Entities;

namespace Tudskee.Data.Repositories
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T>
            where T : class, IEntityBase, new()
    {
        private readonly IUnitOfWork _unitOfWork;

        public EntityBaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        protected ISession Session { get { return _unitOfWork.GetSession(); } }

        public virtual IQueryable<T> GetAll()
        {
            return Session.Query<T>();
        }
        public virtual IQueryable<T> All
        {
            get
            {
                return GetAll();
            }
        }
        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = Session.Query<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Fetch(includeProperty);
            }
            return query;
        }
        public T GetSingle(int id)
        {
            return Session.Get<T>(id);
        }
        public virtual IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return Session.Query<T>().Where(predicate);
        }

        public virtual void Add(T entity)
        {
            Session.Save(entity);
        }
        public virtual void Edit(T entity)
        {
            Session.Update(entity);
        }
        public virtual void Delete(T entity)
        {
            Session.Delete(Session.Load<T>(entity));
        }
    }
}
