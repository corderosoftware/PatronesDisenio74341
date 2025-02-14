using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheeseDecorator : BurgerDecorator
    {
        public CheeseDecorator(IBurger burger) : base(burger) {}

        public override string GetDescription()
        {
            return  _burger.GetDescription() + " Chedar";
        }
        public override double GetCost()
        {
            return _burger.GetCost() + 2500;
        }

        //Más funcionalidad

    }
}
