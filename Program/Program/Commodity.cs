// <copyright file="Commodity.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Napas
{
    using System;
    using System.Collections.Generic;
    using System.Text;

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
        public Commodity(int id, string name, int price) {
            this.Id = id;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; protected set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Цена.
        /// </summary>
        public int Price { get; protected set; }

        /// <summary>
        /// Представление объекта товар в виде строки.
        /// </summary>
        /// <returns>Строковое представление товара.</returns>
        public override string ToString() => $"{this.Name} {this.Id} {this.Price}";

    }
}
