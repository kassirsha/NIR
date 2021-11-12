// <copyright file="Operator.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Napas
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Customer
    {
        public Customer(int Id, string Name, string CreditCard)
        {
            this.Id = Id;
            this.Name = Name;
            this.CreditCard = CreditCard;
        }

        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public string CreditCard { get; protected set; }
        public override string ToString() => $"{this.Name} {this.Id} {this.CreditCard}";
    }
}
