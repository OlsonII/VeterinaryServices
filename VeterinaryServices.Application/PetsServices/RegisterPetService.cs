using System.Linq;
using System.Threading.Tasks;
using VeterinaryServices.Application.PetsServices.Requests;
using VeterinaryServices.Application.PetsServices.Responses;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;

namespace VeterinaryServices.Application.PetsServices
{
    //TODO: EXPLAIN OTHER SERVICE FOCUS
    public class RegisterPetService
    {
        private readonly IUnitOfWork _unitOfWork;

        public RegisterPetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<RegisterPetResponse> Execute(RegisterPetRequest request)
        {
            var clientInDb = await _unitOfWork.ClientRepository.Find(request.OwnerId);
            if (clientInDb == null)
                return null; //TODO: REGISTER CLIENT HERE
            
            var clientPets = await _unitOfWork.PetRepository.FindBy(pet => pet.OwnerId == clientInDb.Id);
            var petRegistered = clientPets.FirstOrDefault(pet => pet.Name == request.PetName && pet.Gender == request.PetGender && pet.Color == request.PetColor);
            
            if (petRegistered != null)
                return null; //TODO: PET IS REGISTERED EXCEPTION

            var petToRegister = new Pet
            {
                Name = request.PetName,
                Color = request.PetColor,
                Gender = request.PetGender,
                Kind = request.PetKind,
                Size = request.PetSize,
                Weight = request.PetWeight,
                OwnerId = request.OwnerId
            };

            await _unitOfWork.PetRepository.Insert(petToRegister);
            await _unitOfWork.Commit();

            return new RegisterPetResponse
            {
                Message = "Mascota registrada satisfactoriamente"
            };
        }
    }
}