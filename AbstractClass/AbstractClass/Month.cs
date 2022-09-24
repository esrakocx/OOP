using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Month
    {
        public int DayHours()
        {
            return 24;
        }

        public abstract int howManyDays();
        public abstract int whichMonth();
    }
}
