// <copyright file="Customer.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Покупатель.
    /// </summary>
    public class Customer : BaseEntity<Customer>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="name">Имя. </param>
        /// <param name="surname">Фамилия. </param>
        /// <param name="creditCard">Номер Карты. </param>
        public Customer(string name, string surname, string creditCard)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.CreditCard = creditCard ?? throw new ArgumentNullException(nameof(creditCard));
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="Customer"/>.
        /// </summary>
        [Obsolete("for ORM", true)]
        protected Customer()
        {
        }

        /// <summary>
        /// Получает или задает имя.
        /// </summary>
        public virtual string Name { get; protected set; }

        /// <summary>
        /// Получает или задает фамилию.
        /// </summary>
        public virtual string Surname { get; protected set; }

        /// <summary>
        /// Получает или задает Номер Карты.
        /// </summary>
        public virtual string CreditCard { get; protected set; }

        /// <summary>
        /// Получает или задает заказ.
        /// </summary>
        public virtual ISet<Order> Orders { get; protected set; } = new HashSet<Order>();

        /// <summary>
        /// Представление объекта покупатель в виде строки.
        /// </summary>
        /// <returns>Строковое представление покупатель.</returns>
        public override string ToString() => $"{this.Name} {this.CreditCard}";
    }
}
