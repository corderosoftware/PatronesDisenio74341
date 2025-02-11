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
            //throw new NotImplementedException();
            return 10000;
        }

        public string GetDescription()
        {
            //throw new NotImplementedException();
            return "Basic burger";
        }
    }
}
