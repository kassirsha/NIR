// <copyright file="Product.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System;

    /// <summary>
    /// Товар.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Product"/>.
        /// </summary>
        /// <param name="id">Идентификатор. </param>
        /// <param name="name">Имя. </param>
        /// <param name="price">Цена. </param>
        public Product(Guid id, string name, decimal price)
        {
            this.Id = id;
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Price = price;
        }

        /// <summary>
        /// Получает или задает идентификатор.
        /// </summary>
        public virtual Guid Id { get; protected set; }

        /// <summary>
        /// Получает или задает имя.
        /// </summary>
        public virtual string Name { get; protected set; }

        /// <summary>
        /// Получает или задает цену.
        /// </summary>
        public virtual decimal Price { get; protected set; }

        /// <summary>
        /// Представление объекта товар в виде строки.
        /// </summary>
        /// <returns>Строковое представление товара.</returns>
        public override string ToString() => $"Номер: {this.Id} \n Название: {this.Name} \n Цена: {this.Price}";

    }
}
