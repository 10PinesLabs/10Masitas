using FluentNHibernate.Mapping;
using _10Masitas.Domain;

namespace _10Masitas.DataBase.Mappings
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap()
        {
            Id(o => o.Id);
            HasMany(o => o.FellowDinners)
                .KeyColumn("IdFellowDinner")
                .Table("FellowDinners")
                .Element("FellowDinnerName"); 
        }
    }
}
