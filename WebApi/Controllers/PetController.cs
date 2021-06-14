﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VeterinaryServices.Application.PetsServices;
using VeterinaryServices.Application.PetsServices.Requests;
using VeterinaryServices.Domain.Contracts;

namespace WebApi.Controllers
{
    //TODO: IMPLEMENT API VERSION
    [ApiController]
    // [ApiVersion("1")]
    [Route("pets")]
    public class PetController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PetController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> RegisterPet(RegisterPetRequest request)
        {
            var service = new RegisterPetService(_unitOfWork);
            var response = await service.Execute(request);
            return Ok(response);
        }
    }
}