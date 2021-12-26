namespace Store.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Store.Core;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="LineItems"/> на таблицу в БД и наоборот.
    /// </summary>
    internal class LineItemsMap : ClassMap<LineItems>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="LineItemsMap"/>.
        /// </summary>
        public LineItemsMap()
        {
            this.Table("LineItems");

            this.Id(x => x.Id).GeneratedBy.Guid();

        }
    }
}