using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Application.PetsServices.Requests
{
    //TODO: ADD VALIDATIONS HERE
    public class RegisterPetRequest
    {
        public Client Owner { get; set; }
        public string Name { get; set; }
        public string Kind { get; set; }
        public double Weight { get; set; }
        public Gender Gender { get; set; }
        public PetSize Size { get; set; }
        public string Color { get; set; }
    }
}