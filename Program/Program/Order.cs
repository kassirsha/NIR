// <copyright file="Order.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Список товаров.
    /// </summary>
    public class Order : BaseEntity<Order>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="orderTotal">Итоговая цена.</param>
        public Order(decimal orderTotal)
        {
            this.OrderTotal = orderTotal;
        }

        /// <summary>
        /// Получает или задает количество.
        /// </summary>
        public virtual decimal OrderTotal { get; protected set; }

        /// <summary>
        /// Получает или задает товары.
        /// </summary>
        public ISet<Product> Products { get; protected set; } = new HashSet<Product>();
    }
}
