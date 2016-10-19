using System.Collections;
using System.Collections.Generic;

namespace _10Masitas.Domain
{
    public class Order
    {
        public IList FellowDinners { get; set; }

        public Order()
        {
            FellowDinners = new List<string>();
        }

        public bool IsActive()
        {
            return true;
        }

        public bool HasFellowsDinners()
        {
            return !FellowDinners.IsEmpty();
        }

        public void AddFellowDinner(string aFellowDinner)
        {
            FellowDinners.Add(aFellowDinner);
        }
    }
}