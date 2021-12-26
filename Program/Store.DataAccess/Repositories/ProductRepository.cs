
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
    public class ProductRepository : IRepository<Product>
    {
        private ISession session;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="session"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public ProductRepository(ISession session)
        {
            this.session = session
                ?? throw new ArgumentNullException(nameof(session));
        }

        /// <inheritdoc/>
        public IQueryable<Product> Filter(Expression<Func<Product, bool>> predicate)
        {
            return this.GetAll().Where(predicate);
        }


        /// <inheritdoc/>
        public Product Find(Expression<Func<Product, bool>> predicate)
        {
            return this.GetAll().FirstOrDefault(predicate);
        }

        public Product Get(Guid id)
        {
            return this.session?.Get<Product>(id);
        }

        /// <inheritdoc/>
        public IQueryable<Product> GetAll()
        {
            return this.session?.Query<Product>();
        }

        /// <inheritdoc/>
        public bool Save(Product entity)
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
        public Product GetByName(string name)
        {
            return this.GetAll().FirstOrDefault<Product>(x => x.Name == name);
        }

        public IQueryable<Product> FindBooksStartNameWith(string str)
        {
            return this.GetAll().Where(x => x.Name.StartsWith(str));
        }
        
    }
}
