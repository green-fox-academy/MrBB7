using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Tree : Plant
    {

        List<string> trees = new List<Tree>();

        public Tree(string plantColor, int needForWater, double waterAbsorb) : base(plantColor, needForWater, waterAbsorb)
        {            
        }

        public Tree(string plantColor, int needForWater, double waterAbsorb)
        {
            plantColor = "purple";
            needForWater = 10;
            waterAbsorb = 0.4;
        }
    }
}
