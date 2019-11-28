using Client.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Client.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties

        private ClientEntities dataContext;
        private readonly DbSet<T> dbSet;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        protected ClientEntities DbContext
        {
            get { return dataContext ?? (dataContext = DbFactory.Init()); }
        }

        #endregion



        protected RepositoryBase(ClientEntities _dataContext)
        {
            //DbFactory = dbFactory;
            dataContext = _dataContext;
            dbSet = DbContext.Set<T>();
        }

        #region Implementation
        public virtual void Add(T entity)
        {
            dbSet.Add(entity);
            dataContext.Commit();
        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
            dataContext.Commit();
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
            dataContext.Commit();
        }

        public virtual void Delete(int id)
        {
             var entity = dbSet.Find(id);
            dbSet.Remove(entity);
            dataContext.Commit();
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
            dataContext.Commit();
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }


        public void Commit()
        {
            DbContext.Commit();
        }

        #endregion

    }
}
