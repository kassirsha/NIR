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
    public class CustomerRepository : IRepository<Customer>
    {
        private ISession session;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public CustomerRepository(ISession session)
        {
            this.session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Customer> Filter(Expression<Func<Customer, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }


        /// <inheritdoc/>
        public Customer Find(Expression<Func<Customer, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Customer Get(Guid id)
        {
            return this.session?.Get<Customer>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Customer> GetAll()
        {
            return this.session?.Query<Customer>();
        }

        /// <inheritdoc/>
        public bool Save(Customer entity)
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
        public Customer GetByName(string name)
        {
            return this.GetAll().FirstOrDefault<Customer>(x => x.Name == name);
        }

        public IQueryable<Customer> FindBooksStartNameWith(string str)
        {
            return this.GetAll().Where(x => x.Name.StartsWith(str));
        }

    }
}
