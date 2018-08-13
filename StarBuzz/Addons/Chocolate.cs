using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Chocolate : CondimentDecorator
    {
        private Beverage _beverage;
        public Chocolate(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double Cost()
        {
            return .20 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDesription() + ", Chocolate";
        }
    }
}
