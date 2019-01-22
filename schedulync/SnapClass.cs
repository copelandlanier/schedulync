using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_NEW
{
     partial class Day_Control 
    {
        public int RoundEr(int i)
        {
            return ((int)Math.Round(i / 20.0)) * 20;
        }
    }
}
