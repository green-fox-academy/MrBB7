using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Plant
    {
        private string plantColor;
        private int needForWater;
        private double waterAbsorb;


        public Plant( string plantColor, int needForWater, double waterAbsorb)
        {
            this.plantColor = plantColor;
            this.needForWater = needForWater;
            this.waterAbsorb = waterAbsorb;
        }

        public string PantColor
        {
            get
            {
                return plantColor;
            }
        }

        public int NeedForWater
        {
            get
            {
                return needForWater;
            }
        }

        public double WaterAbsorb
        {
            get
            {
                return waterAbsorb;
            }
        }
    }
}
