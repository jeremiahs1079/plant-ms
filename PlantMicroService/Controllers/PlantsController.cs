using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PlantMicroService.Models;
using PlantMicroService.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlantMicroService.Controllers
{
    [Route("api/[controller]")]
    public class PlantsController : Controller
    {

        public readonly IPlantService PlantService;

        public PlantsController(IPlantService plantService)
        {
            PlantService = plantService;
        }




        // GET: api/plants
        [HttpGet]
        public IEnumerable<Plant> Get([FromQuery] int typeId, [FromQuery] int locationId)
        {
            if(!string.IsNullOrEmpty(Request.Query["typeId"]) && !string.IsNullOrEmpty(Request.Query["locationId"]))
            {
                return PlantService.getPlantsByType(typeId).Where(p => p.LocationId == locationId).ToList();
            }

            if (!string.IsNullOrEmpty(Request.Query["typeId"]))
            {
                return PlantService.getPlantsByType(typeId);
            }

            if (!string.IsNullOrEmpty(Request.Query["locationId"])) {
                return PlantService.getPlantsByLocation(locationId);
            }


            return PlantService.getPlants();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Plant Get(int id)
        {
            return PlantService.getPlant(id);
        }

        // POST api/values
        [HttpPost]
        public Plant Post([FromBody]Plant plant)
        {
            return PlantService.postPlant(plant);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Plant plant)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
