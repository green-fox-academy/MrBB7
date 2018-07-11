using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Flower : Plant
    {
        public Flower(string plantColor) : base(plantColor)
        {

        }

        public override string NeedForWater()
        {
            if (CurrentWaterLevel < 5)
            {
                return String.Format("This {0} flower needs water", GetColor);
            }
            else
            {
                return String.Format("This {0} flower doesn't need water", GetColor);
            }
        }

        public override double WaterAbsorb(double getWater)
        {
            double waterAbsorb = getWater * 0.75;
            return waterAbsorb;
        }
    }
}
