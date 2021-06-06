using System.Threading;
using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Infrastructure.Base;

namespace VeterinaryServices.Infrastructure.Repositories
{
    public class HospitalizationRepository : GenericRepository<Hospitalization>, IHospitalizationRepository
    {
        public HospitalizationRepository(DbContext context) : base(context)
        {
        }
    }
}