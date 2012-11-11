﻿using NHibernate;

namespace Unilib.CommunicationServer.Common
{
    public interface IRepository<in T> where T:IEntity
    {
        ISessionFactory SessionFactory { get; set; }

        void SaveOrUpdate(T entity);
    }

    public class Repository<T> : IRepository<T> where T:IEntity
    {
        #region IRepository<T> Members

        public ISessionFactory SessionFactory { get; set; }

        public void SaveOrUpdate(T entity)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Save(entity);
                    transaction.Commit();
                }
            }

        }

        #endregion
    }

}