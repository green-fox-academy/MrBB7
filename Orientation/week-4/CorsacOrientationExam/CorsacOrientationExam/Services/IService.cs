using CorsacOrientationExam.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CorsacOrientationExam.Services
{
    public interface IService
    {
        SpaceEntityDTO GetAllSpaceEntities();
        void MoveSpaceShipToPlanetById(int id);
        void MovePeopleToShip(int id);
        void MovePeopleToplanet(int id);
    }
}
