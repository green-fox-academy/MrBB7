using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Tree : Plant
    {
        public Tree(string plantColor) : base(plantColor)
        {

        }

        public override string NeedForWater()
        {
            if (CurrentWaterLevel < 10)
            {
                return String.Format("This {0} tree needs water", GetColor);
            }
            else
            {
                return String.Format("This {0} tree doesn't need water", GetColor);
            }
        }

        public override double WaterAbsorb(double getWater)
        {
            double waterAbsorb = getWater * 0.4;
            return waterAbsorb;
        }
    }
}
