using System;
using System.Collections.Generic;
using PlantMicroService.Models;

namespace PlantMicroService.Services
{
    public interface IPlantService
    {
        List<Plant> getPlants();
        Plant getPlant(int id);
        List<Plant> getPlantsByType(int typeId);
        List<Plant> getPlantsByLocation(int locationId);
        Plant postPlant(Plant plant);
    }
}
