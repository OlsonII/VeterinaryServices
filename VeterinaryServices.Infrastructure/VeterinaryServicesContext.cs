using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Entities;

namespace VeterinaryServices.Infrastructure
{
    public class VeterinaryServicesContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<AestheticService> AestheticServices { get; set; }
        public DbSet<Hospitalization> Hospitalizations { get; set; }
        public DbSet<MedicalAppointment> MedicalAppointments { get; set; }
        
        public VeterinaryServicesContext(DbContextOptions options) : base(options)
        {
        }
    }
}