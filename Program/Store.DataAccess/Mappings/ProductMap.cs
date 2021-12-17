namespace Store.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Store.Core;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Product"/> на таблицу в БД и наоборот.
    /// </summary>
    internal class ProductMap : ClassMap<Product>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ProductMap"/>.
        /// </summary>
        public ProductMap()
        {
            this.Table("Product");

            this.Id(x => x.Id).GeneratedBy.Guid();

            this.Map(x => x.Name).Length(255);

            this.Map(x => x.Price).Length(255);

            this.HasOne(x => x.Order)
                .Cascade.Delete();

        }
    }
}
