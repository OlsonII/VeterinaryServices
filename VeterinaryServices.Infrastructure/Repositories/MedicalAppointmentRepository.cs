using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Domain.Entities;
using VeterinaryServices.Infrastructure.Base;

namespace VeterinaryServices.Infrastructure.Repositories
{
    public class MedicalAppointmentRepository : GenericRepository<MedicalAppointment>, IMedicalAppointmentRepository
    {
        public MedicalAppointmentRepository(DbContext context) : base(context)
        {
        }
    }
}