using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Application.PetsServices.Requests
{
    //TODO: ADD VALIDATIONS HERE
    public class RegisterPetRequest
    {
        public long OwnerId { get; set; }
        public string OwnerNames { get; set; }
        public string OwnerSurnames { get; set; }
        public string OwnerPhone { get; set; }
        public string OwnerAddress { get; set; }
        public Gender OwnerGender { get; set; }
        public int OwnerAge { get; set; }
        public string PetName { get; set; }
        public string PetKind { get; set; }
        public double PetWeight { get; set; }
        public Gender PetGender { get; set; }
        public PetSize PetSize { get; set; }
        public string PetColor { get; set; }
    }
}