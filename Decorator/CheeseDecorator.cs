using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription();
        }
        public override double GetCost()
        {
            return base.GetCost();
        }

    }
}
