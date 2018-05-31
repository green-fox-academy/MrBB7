using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Plant
    {
        private string plantColor;
        private double currentWater;


        public Plant( string plantColor)
        {
            this.plantColor = plantColor;
            this.currentWater = 0;
        }

        public double CurrentWaterLevel
        {
            get
            {
                return currentWater;
            }
        }

        public void SetCurrentWater(double change)
        {
            currentWater += change;
        }

        public string GetColor
        {
            get
            {
                return plantColor;
            }
        }

        public virtual string NeedForWater()
        {
            return "";
        }

        public virtual double WaterAbsorb(double getWater)
        {
            double waterAbsorb = 0.0;
            return waterAbsorb;
        }
    }
}
