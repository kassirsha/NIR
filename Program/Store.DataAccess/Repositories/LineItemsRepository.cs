
namespace Store.DataAccess.Repositories
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;
    using Store.Core;
    using NHibernate;

    /// <summary>
    /// Репозиторий для Книги.
    /// </summary>
    public class LineItemsRepository : IRepository<LineItems>
    {
        private ISession session;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public LineItemsRepository(ISession session)
        {
            this.session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<LineItems> Filter(Expression<Func<LineItems, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }


        /// <inheritdoc/>
        public LineItems Find(Expression<Func<LineItems, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public LineItems Get(Guid id)
        {
            return this.session?.Get<LineItems>(id);
        }

        /// <inheritdoc/>
        public IQueryable<LineItems> GetAll()
        {
            return this.session?.Query<LineItems>();
        }

        /// <inheritdoc/>
        public bool Save(LineItems entity)
        {
            try
            {
                this.session?.Save(entity);
                this.session.Flush();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}