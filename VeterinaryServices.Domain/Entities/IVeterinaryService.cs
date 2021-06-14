using System;

namespace VeterinaryServices.Domain.Entities
{
    public interface IVeterinaryService
    {
        public long DoctorId { get; set; }
        public long PetId { get; set; }
        DateTime Date { get; set; }
        Double Cost { get; set; }
        void Input(long petId, long doctorId);
        void Output();
    }
}