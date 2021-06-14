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
            var clientInDb = await _unitOfWork.ClientRepository.Find(request.Owner.Id);
            if (clientInDb == null)
                return null; //TODO: REGISTER CLIENT HERE
            
            var clientPets = await _unitOfWork.PetRepository.FindBy(pet => pet.OwnerId == clientInDb.Id);
            var petRegistered = clientPets.FirstOrDefault(pet => pet.Name == request.Name && pet.Gender == request.Gender && pet.Color == request.Color);

            if (petRegistered != null)
                return null; //TODO: PET IS REGISTERED EXCEPTION

            var petToRegister = new Pet
            {
                Name = request.Name,
                Color = request.Color,
                Gender = request.Gender,
                Kind = request.Kind,
                Size = request.Size,
                Weight = request.Weight,
                OwnerId = request.Owner.Id
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