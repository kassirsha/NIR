
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
    public class OrderRepository : IRepository<Order>
    {
        private ISession session;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public OrderRepository(ISession session)
        {
            this.session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Order> Filter(Expression<Func<Order, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }


        /// <inheritdoc/>
        public Order Find(Expression<Func<Order, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Order Get(Guid id)
        {
            return this.session?.Get<Order>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Order> GetAll()
        {
            return this.session?.Query<Order>();
        }

        /// <inheritdoc/>
        public bool Save(Order entity)
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
/*
        public Order GetByTitle(string title)
        {
            return this.GetAll().FirstOrDefault<Order>(x => x.Title == title);
        }

        public IQueryable<Order> FindBooksStartNameWith(string str)
        {
            return this.GetAll().Where(x => x.Order.StartsWith(str));
        }
*/
    }
}