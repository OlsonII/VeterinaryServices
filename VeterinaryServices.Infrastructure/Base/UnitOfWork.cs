using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using VeterinaryServices.Domain.Contracts;
using VeterinaryServices.Infrastructure.Repositories;

namespace VeterinaryServices.Infrastructure.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;
        private IClientRepository _clientRepository { get; set; }
        private IDoctorRepository _doctorRepository { get; set; }
        private IHospitalizationRepository _hospitalizationRepository { get; set; }
        private IMedicalAppointmentRepository _medicalAppointmentRepository { get; set; }
        private IPetRepository _petRepository { get; set; }
        private IAestheticServiceRepository _aestheticServiceRepository { get; set; }

        public IClientRepository ClientRepository
        {
            get { return _clientRepository ??= new ClientRepository(_dbContext); }
        }

        public IDoctorRepository DoctorRepository
        {
            get { return _doctorRepository ??= new DoctorRepository(_dbContext); }
        }

        public IHospitalizationRepository HospitalizationRepository
        {
            get { return _hospitalizationRepository ??= new HospitalizationRepository(_dbContext); }
        }

        public IMedicalAppointmentRepository MedicalAppointmentRepository
        {
            get { return _medicalAppointmentRepository ??= new MedicalAppointmentRepository(_dbContext); }
        }

        public IPetRepository PetRepository
        {
            get { return _petRepository ??= new PetRepository(_dbContext); }
        }

        public IAestheticServiceRepository AestheticServiceRepository
        {
            get { return _aestheticServiceRepository ??= new AestheticServiceRepository(_dbContext); }
        }

        public UnitOfWork(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Commit()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}