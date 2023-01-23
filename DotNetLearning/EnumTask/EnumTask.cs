using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DotNetLearning.EnumTask
{
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public class EnumTask
    {
        public DaysOfTheWeek GetFirstDayOfTheWeek()
        {
            DaysOfTheWeek first = (DaysOfTheWeek)0;
            return first;
        }

        public DaysOfTheWeek GetDayOfTheWeek(int index)
        {
            DaysOfTheWeek select = (DaysOfTheWeek)index;
            return select;
        }

        public List<string> GetAllDaysOfTheWeek()
        { 
            List <DaysOfTheWeek> days = Enum.GetValues(typeof(DaysOfTheWeek))
                            .Cast<DaysOfTheWeek>()
                            .ToList();
            var strings = (from o in days select o.ToString()).ToList();
            return strings;

        }
    }
}
