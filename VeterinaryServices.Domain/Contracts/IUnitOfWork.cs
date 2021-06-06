using System.Threading.Tasks;

namespace VeterinaryServices.Domain.Contracts
{
    public interface IUnitOfWork
    {
        IClientRepository ClientRepository { get; }
        IDoctorRepository DoctorRepository { get; }
        IHospitalizationRepository HospitalizationRepository { get; }
        IMedicalAppointmentRepository MedicalAppointmentRepository { get; }
        IPetRepository PetRepository { get; }
        IAestheticServiceRepository AestheticServiceRepository { get; }
        
        /// <summary>
        ///     This save all changes pending
        /// </summary>
        Task Commit();
    }
}