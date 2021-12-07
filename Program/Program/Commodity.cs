// <copyright file="Commodity.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System.Collections.Generic;

    /// <summary>
    /// Товар.
    /// </summary>
    public class Commodity
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Commodity"/>.
        /// </summary>
        /// <param name="id">Идентификатор. </param>
        /// <param name="name">Имя. </param>
        /// <param name="price">Цена. </param>
        public Commodity(int id, string name, int price)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Получает или задает идентификатор.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// Получает или задает имя.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Получает или задает цену.
        /// </summary>
        public int Price { get; protected set; }

        /// <summary>
        /// Представление объекта товар в виде строки.
        /// </summary>
        /// <returns>Строковое представление товара.</returns>
        public override string ToString() => $"Номер: {this.Id} \n Название: {this.Name} \n Цена: {this.Price}";

        /// <summary>
        /// Получает или задает товары.
        /// </summary>
        public ISet<Commodity> Commodities { get; protected set; } = new HashSet<Commodity>();
    }
}
