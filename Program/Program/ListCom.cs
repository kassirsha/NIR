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
        /// <param name="quantity">Количество.</param>
        /// <param name="commodities">Товары.</param>
        public ListCom(int quantity, params Commodity[] commodities)
            : this(quantity, new HashSet<Commodity>(commodities))
        {
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="ListCom"/>.
        /// </summary>
        /// <param name="quantity">Количество.</param>
        /// <param name="commodities">Множество товаров.</param>
        public ListCom(int quantity, ISet<Commodity> commodities = null)
        {
            this.Quantity = quantity;
            foreach (var commodity in commodities ?? Enumerable.Empty<Commodity>())
            {
                this.Commodities.Add(commodity);
            }
        }

        /// <summary>
        /// Получает или задает количество.
        /// </summary>
        public int Quantity { get; protected set; }

        /// <summary>
        /// Получает или задает товары.
        /// </summary>
        public ISet<Commodity> Commodities { get; protected set; } = new HashSet<Commodity>();
    }
}
