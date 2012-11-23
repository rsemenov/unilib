using NHibernate;

namespace Unilib.Common.Interfaces
{
    public interface IRepository<in T> where T:IEntity
    {
        ISessionFactory SessionFactory { get; set; }

        void Add(T entity);
        void Update(T entity);
    }

    public class Repository<T> : IRepository<T> where T:IEntity
    {
        #region IRepository<T> Members

        public ISessionFactory SessionFactory { get; set; }

        public void Add(T entity)
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

        public void Update(T entity)
        {
            using (var session = SessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    session.Update(entity);
                    transaction.Commit();
                }
            }

        }

        #endregion
    }

}