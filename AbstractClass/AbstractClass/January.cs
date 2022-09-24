using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class January : Month
    {
        public override int howManyDays()
        {
            return 31;
        }

        public override int whichMonth()
        {
            return 1;
        }
    }
}
