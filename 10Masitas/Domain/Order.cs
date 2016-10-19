using System;
using System.Collections.Generic;

namespace _10Masitas.Domain
{
    public class Order
    {
        public virtual Guid Id { get; protected set; }
        public virtual IList<string> FellowDinners { get; set; }

        public Order()
        {
            FellowDinners = new List<string>();
        }

        public virtual bool IsActive()
        {
            return true;
        }

        public virtual bool HasFellowsDinners()
        {
            return !FellowDinners.IsEmpty();
        }

        public virtual void AddFellowDinner(string aFellowDinner)
        {
            FellowDinners.Add(aFellowDinner);
        }

        public virtual bool ContainsFellowDinner(string aFellowDinner)
        {
            return FellowDinners.Contains(aFellowDinner);
        }
    }
}