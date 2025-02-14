using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BasicBurger : IBurger
    {
        public double GetCost()
        {
            return 10000;
        }

        public string GetDescription()
        {
            return "Basic burger";
        }
    }
}
