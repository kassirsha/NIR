// <copyright file="Product.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Товар.
    /// </summary>
    public class Product : BaseEntity<Product>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="name">Имя. </param>
        /// <param name="price">Цена. </param>
        public Product(string name, decimal price)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Price = price;
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Product"/>.
        /// </summary>
        [Obsolete("for ORM", true)]
        protected Product()
        { }

        /// <summary>
        /// Получает или задает имя.
        /// </summary>
        public virtual string Name { get; protected set; }

        /// <summary>
        /// Получает или задает цену.
        /// </summary>
        public virtual decimal Price { get; protected set; }

        /// <summary>
        /// Получает или задает заказ.
        /// </summary>
        public virtual Order Order { get; protected set; }

        public virtual ISet<Order> Orders { get; protected set; } = new HashSet<Order>();
        /// <summary>
        /// Представление объекта товар в виде строки.
        /// </summary>
        /// <returns>Строковое представление товара.</returns>
        public override string ToString() => $"Название: {this.Name} \n Цена: {this.Price}";

    }
}
