using System;
using System.Collections.Generic;
using System.Text;

namespace Garden
{
    class Garden
    {
        private List<Plant> plantsInTheGarden = new List<Plant>();

        public void AddPlants(Plant plant1, Plant plant2, Plant plant3, Plant plant4)
        {
            plantsInTheGarden.Add(plant1);
            plantsInTheGarden.Add(plant2);
            plantsInTheGarden.Add(plant3);
            plantsInTheGarden.Add(plant4);
        }


        public string StateOfTheGarden()
        {
            string output = "";

            for (int i = 0; i < plantsInTheGarden.Count; i++)
            {
                output += plantsInTheGarden[i].NeedForWater();
                if (i < plantsInTheGarden.Count - 1)
                {
                    output += "\n";
                }
            }
            return output;
        }

        public void Watering(int waterAmount)
        {
            double waterAmountForEachPlant = waterAmount / plantsInTheGarden.Count;

            for (int i = 0; i < plantsInTheGarden.Count; i++)
            {
                plantsInTheGarden[i].SetCurrentWater(plantsInTheGarden[i].WaterAbsorb(waterAmountForEachPlant));
            }
        }
    }
}

