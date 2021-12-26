// <copyright file="LineItems.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System;

    /// <summary>
    /// Список товаров.
    /// </summary>
    public class LineItems : BaseEntity<LineItems>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="LineItems"/>.
        /// </summary>
        /// <param name="number">Количество.</param>
        public LineItems(int number)
        {
            this.Number = number;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="LineItems"/>.
        /// </summary>
        [Obsolete("for ORM", true)]
        protected LineItems()
        {
        }

        /// <summary>
        /// Получает или задает список товаров.
        /// </summary>
        public virtual int Number { get; protected set; }

        /// <summary>
        /// Получает или задает список товар.
        /// </summary>
        public virtual Product Product { get; protected set; }

        /// <summary>
        /// Получает или задает список заказ.
        /// </summary>
        public virtual Order Order { get; protected set; }

        /// <summary>
        /// Функция заказать.
        /// </summary>
        /// <param name="product">Заказать.</param>
        public virtual void Purchase(Product product)
        {
            this.Product?.LineItems.Remove(this);

            this.Product = product ?? throw new ArgumentNullException(nameof(product));

            this.Product?.LineItems.Add(this);
        }

        /// <summary>
        /// Функция добавить в заказ.
        /// </summary>
        /// <param name="order">Добавить в заказ.</param>
        public virtual void AddOrder(Order order)
        {
            this.Order?.LineItems.Remove(this);

            this.Order = order ?? throw new ArgumentNullException(nameof(order));

            this.Order?.LineItems.Add(this);
        }
    }
}
