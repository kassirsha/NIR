namespace Store.DataAccess.Mappings
{
    using FluentNHibernate.Mapping;
    using Store.Core;

    /// <summary>
    /// Класс, описывающий правила отображения <see cref="Commodity"/> на таблицу в БД и наоборот.
    /// </summary>
    internal class CommMap : ClassMap<Commodity>
    {
        /// <summary>
        /// Инициализирует новый экземпляр класса <see cref="CommMap"/>.
        /// </summary>
        public CommMap()
        {
            this.Table("Commodities");

            this.Id(x => x.Id);

            this.Map(x => x.Name);


        }
    }
}
