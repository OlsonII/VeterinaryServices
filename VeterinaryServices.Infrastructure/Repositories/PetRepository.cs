using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Infrastructure.Base;

namespace VeterinaryServices.Infrastructure.Repositories
{
    public class PetRepository : GenericRepository<Pet>, IPetRepository
    {
        public PetRepository(DbContext context) : base(context)
        {
        }
    }
}