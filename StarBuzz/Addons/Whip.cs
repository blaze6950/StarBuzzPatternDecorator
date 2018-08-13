using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzz
{
    class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            this._beverage = beverage;
        }
        public override double Cost()
        {
            return .10 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDesription() + ", Whip";
        }
    }
}
