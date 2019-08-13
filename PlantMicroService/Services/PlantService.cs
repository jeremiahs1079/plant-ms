using System;
using System.Collections.Generic;
using System.Linq;
using PlantMicroService.Models;

namespace PlantMicroService.Services
{
    public class PlantService : IPlantService
    {

        private List<Plant> Plants;

        public PlantService()
        {
            Plants = new List<Plant>();

            Plants.Add
                (
                    new Plant
                    {
                        Id = 1,
                        Name =  "Test Plant 1",
                        TypeId = 1,
                        LocationId = 1
                    }
                );

            Plants.Add
                (
                    new Plant
                    {
                        Id = 2,
                        Name = "Test Plant 2",
                        TypeId = 1,
                        LocationId = 2
                    }
                );
            Plants.Add
                (
                    new Plant
                    {
                        Id = 3,
                        Name = "Test Plant 2",
                        TypeId = 2,
                        LocationId = 2
                    }
                );
            Plants.Add
                (
                    new Plant
                    {
                        Id = 4,
                        Name = "Test Plant 2",
                        TypeId = 3,
                        LocationId = 3
                    }
                );
            Plants.Add
                (
                    new Plant
                    {
                        Id = 5,
                        Name = "Test Plant 2",
                        TypeId = 3,
                        LocationId = 2
                    }
                );
        }

        public Plant getPlant(int id)
        {
            return Plants.Where(p => p.Id == id).FirstOrDefault();
        }

        public List<Plant> getPlants()
        {
            return Plants;
        }

        public List<Plant> getPlantsByLocation(int locationId)
        {
            return Plants.Where(p => p.LocationId == locationId).ToList();
        }

        public List<Plant> getPlantsByType(int typeId)
        {
            return Plants.Where(p => p.TypeId == typeId).ToList();
        }

        public Plant postPlant(Plant plant)
        {
            Plants.Add(plant);

            return this.getPlant(plant.Id);
        }
    }
}
