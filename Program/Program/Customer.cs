// <copyright file="Customer.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System;

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
        /// <param name="surname">Фамилия. </param>
        /// <param name="creditCard">Номер Карты. </param>
        public Customer(Guid id, string name, string surname, string creditCard)
        {
            this.Id = id;
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Surname = surname ?? throw new ArgumentNullException(nameof(surname));
            this.CreditCard = creditCard ?? throw new ArgumentNullException(nameof(creditCard));
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
        /// Получает или задает фамилию.
        /// </summary>
        public virtual string Surname { get; protected set; }

        /// <summary>
        /// Получает или задает Номер Карты.
        /// </summary>
        public virtual string CreditCard { get; protected set; }

        /// <summary>
        /// Представление объекта покупатель в виде строки.
        /// </summary>
        /// <returns>Строковое представление покупатель.</returns>
        public override string ToString() => $"{this.Name} {this.Id} {this.CreditCard}";
    }
}
