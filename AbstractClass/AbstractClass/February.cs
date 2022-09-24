using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class February : Month
    {
        public override int howManyDays()
        {
            return 28;
        }

        public override int whichMonth()
        {
            return 2;
        }
    }
}
