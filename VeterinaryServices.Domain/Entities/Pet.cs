using VeterinaryServices.Domain.Base;
using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public class Pet : Entity<long>
    {
        public long OwnerId { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public double Weight { get; set; }
        public Gender Gender { get; set; }
        public PetSize Size { get; set; }
        public string Color { get; set; }
        public string Profile { get; set; }
    }
}