namespace Store.Core
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public class LineItems : BaseEntity<LineItems>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="LineItems"/>.
        /// </summary>
        [Obsolete("for ORM", true)]
        protected LineItems()
        { }

        //public virtual Order Order { get; protected set; }
        //public virtual Order Product { get; protected set; }

        /// <summary>
        /// Получает или задает заказ.
        /// </summary>
        //public virtual ISet<Product> Products { get; protected set; } = new HashSet<Product>();

        /// <summary>
        /// Получает или задает заказ.
        /// </summary>
        //public virtual ISet<Order> Orders { get; protected set; } = new HashSet<Order>();
    }
}
