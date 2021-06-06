using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Infrastructure.Base;

namespace VeterinaryServices.Infrastructure.Repositories
{
    public class AestheticServiceRepository : GenericRepository<AestheticService>, IAestheticServiceRepository
    {
        public AestheticServiceRepository(DbContext context) : base(context)
        {
        }
    }
}