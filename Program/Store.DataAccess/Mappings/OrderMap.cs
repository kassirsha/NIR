﻿namespace Store.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Store.Core;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Order"/> на таблицу в БД и наоборот.
    /// </summary>
    internal class OrderMap : ClassMap<Order>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="OrderMap"/>.
        /// </summary>
        public OrderMap()
        {
            this.Table("Order");

            this.Id(x => x.Id).GeneratedBy.Guid();

            this.Map(x => x.OrderTotal);

            this.HasMany(x => x.Products);

        }
    }
}
