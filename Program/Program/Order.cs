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
        /// Инициализирует новый экземпляр класса <see cref="Order"/>.
        /// </summary>
        [Obsolete("for ORM", true)]
        protected Order()
        {
        }

        /// <summary>
        /// Получает или задает количество.
        /// </summary>
        public virtual decimal OrderTotal { get; protected set; }

        /// <summary>
        /// Получает или задает заказ.
        /// </summary>
        public virtual Customer Customer { get; protected set; }

        /// <summary>
        /// Получает или задает товары.
        /// </summary>
        public virtual ISet<LineItems> LineItems { get; protected set; } = new HashSet<LineItems>();

        /// <summary>
        /// Функция добавить клиента.
        /// </summary>
        /// <param name="customer">Добавить клиента.</param>
        public virtual void AddCustomer(Customer customer)
        {
            this.Customer?.Orders.Remove(this);

            this.Customer = customer ?? throw new ArgumentNullException(nameof(customer));

            this.Customer?.Orders.Add(this);
        }
    }
}
