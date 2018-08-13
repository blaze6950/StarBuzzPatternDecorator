using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Soy : CondimentDecorator
    {
        private Beverage _beverage;
        public Soy(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double Cost()
        {
            return .15 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDesription() + ", Soy";
        }
    }
}
