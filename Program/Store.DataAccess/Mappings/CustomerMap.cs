
namespace Store.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Store.Core;
    /// <summary>
    /// 
    /// </summary>
    internal class CustomerMap : ClassMap<Customer>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrderMap"/>.
        /// </summary>
        public CustomerMap()
        {
            this.Table("Customer");

            this.Id(x => x.Id).GeneratedBy.Guid();

            this.Map(x => x.Name);

            this.Map(x => x.Surname);

            this.Map(x => x.CreditCard);

            References(x => x.Order);

        }
    }
}
