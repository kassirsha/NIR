// <copyright file="Customer.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Napas
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Покупатель.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="id">Идентификатор. </param>
        /// <param name="name">Имя. </param>
        /// <param name="creditCard">Номер Карты. </param>
        public Customer(int id, string name, string creditCard)
        {
            this.Id = id;
            this.Name = name;
            this.CreditCard = creditCard;
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
        /// Номер Карты.
        /// </summary>
        public string CreditCard { get; protected set; }

        /// <summary>
        /// Представление объекта покупатель в виде строки.
        /// </summary>
        /// <returns>Строковое представление покупатель.</returns>
        public override string ToString() => $"{this.Name} {this.Id} {this.CreditCard}";
    }
}
