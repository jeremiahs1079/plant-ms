using System;
namespace PlantMicroService.Models
{
    public class Plant
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public int LocationId { get; set; }

    }
}
