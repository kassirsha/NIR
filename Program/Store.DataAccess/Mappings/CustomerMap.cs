
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

            this.Map(x => x.Name).Length(255);

            this.Map(x => x.Surname).Length(255);

            this.Map(x => x.CreditCard).Length(255);

            //this.References(x => x.Order);
            this.HasMany(x => x.Orders)
               .Cascade.Delete();


        }
    }
}
