// <copyright file="ListCom.cs" company="NirEpiPol">
// Copyright (c) MIIT
// </copyright>

namespace Store.Core
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Список товаров.
    /// </summary>
    public class ListCom
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ListCom"/>.
        /// </summary>
        /// <param name="name">Имя.</param>
        public ListCom(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Получает или задает количество.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Получает или задает товары.
        /// </summary>
        public ISet<Commodity> Commodities { get; protected set; } = new HashSet<Commodity>();
    }
}

/*

public ListCom(int quantity, ISet<Commodity> commodities = null)
{
    this.Quantity = quantity;
    foreach (var commodity in commodities ?? Enumerable.Empty<Commodity>())
    {
        this.Commodities.Add(commodity);
    }
}
*/