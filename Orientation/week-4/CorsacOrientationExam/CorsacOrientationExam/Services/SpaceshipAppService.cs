using CorsacOrientationExam.Models;
using CorsacOrientationExam.Repositories;
using CorsacOrientationExam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsacOrientationExam.Services
{
    public class SpaceshipAppService : IService
    {
        public SpaceshipAppService(SpaceshipRepository spaceshipRepo, PlanetRepository planetRepo)
        {
            this.spaceshipRepo = spaceshipRepo;
            this.planetRepo = planetRepo;
        }

        private SpaceshipRepository spaceshipRepo { get; set; }
        private PlanetRepository planetRepo { get; set; }

        public SpaceEntityDTO GetAllSpaceEntities()
        {
            return new SpaceEntityDTO
            {
                Planets = planetRepo.Read(),
                Spaceship = spaceshipRepo.Read()[0]
            };
        }

        public void MovePeopleToplanet(int id)
        {
            Planet currentPlanet = planetRepo.Read().FirstOrDefault(p => p.Id.Equals(id));
            Spaceship loadShip = spaceshipRepo.Read().First();

            currentPlanet.Population += loadShip.Utilization;
            loadShip.Utilization = 0;

            spaceshipRepo.Update(loadShip);
            planetRepo.Update(currentPlanet);
        }

        public void MovePeopleToShip(int id)
        {
            Planet currentPlanet = planetRepo.Read().FirstOrDefault(p => p.Id.Equals(id));
            Spaceship loadShip = spaceshipRepo.Read().First();

            int placesLeft = loadShip.MaxCapacity - loadShip.Utilization;

            if (placesLeft > 0 || currentPlanet.Population < 1)
            {
                if (currentPlanet.Population == placesLeft)
                {
                    loadShip.Utilization += placesLeft;
                    currentPlanet.Population = 0;
                }
                else if (currentPlanet.Population > placesLeft)
                {
                    loadShip.Utilization += placesLeft;
                    currentPlanet.Population -= placesLeft;
                }
                else if (currentPlanet.Population < placesLeft)
                {
                    loadShip.Utilization += (int) currentPlanet.Population;
                    currentPlanet.Population = 0;
                }
            }

            spaceshipRepo.Update(loadShip);
            planetRepo.Update(currentPlanet);
        }

        public void MoveSpaceShipToPlanetById(int id)
        {
            string planetName = planetRepo.Read().FirstOrDefault(p => p.Id == id).Name;

            Spaceship shipAtNewLocation = spaceshipRepo.Read().First();

            shipAtNewLocation.Planet = planetName;

            spaceshipRepo.Update(shipAtNewLocation);
        }
    }
}
