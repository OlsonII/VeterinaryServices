using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Infrastructure.Base;

namespace VeterinaryServices.Infrastructure.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>, IDoctorRepository
    {
        public DoctorRepository(DbContext context) : base(context)
        {
        }
    }
}