using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Infrastructure.Base;

namespace VeterinaryServices.Infrastructure.Repositories
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {
        }
    }
}