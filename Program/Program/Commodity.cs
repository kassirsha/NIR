// <copyright file="Class1.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Napas
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Commodity
    {
        //  public Commodity(int Id, string Name, int Price)
        //       : this(Id, Name, Price) { }
        public Commodity(int Id, string Name, int Price) {
            this.Id = Id; this.Name = Name; this.Price = Price;
        }
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Price { get; protected set; }
        
        public override string ToString() => $"{this.Name} {this.Id} {this.Price}";

    }
}
