using System.Collections.Generic;

namespace _10Masitas.Domain
{
    public class LunchManagmentSystem
    {
        public virtual IList<string> FellowDiners { get; set; }

        public LunchManagmentSystem()
        {
            FellowDiners = new List<string>();
        }
        public bool IsEnabledToSignUp()
        {
            return true;
        }

        public void AddFellowDiner(string aFellowDiner)
        {
            FellowDiners.Add(aFellowDiner);
        }

        public bool ExistsFellowDiner(string fellowDiner)
        {
            return !FellowDiners.IsEmpty();
        }
    }
}