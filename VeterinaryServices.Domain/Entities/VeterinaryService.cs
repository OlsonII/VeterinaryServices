using System;
using VeterinaryServices.Domain.Base;

namespace VeterinaryServices.Domain.Entities
{
    public abstract class VeterinaryService : Entity<long>, IVeterinaryService
    {
        public long DoctorId { get; set; }
        public long PetId { get; set; }
        public DateTime Date { get; set; }
        public double Cost { get; set; }

        public void Input(long petId, long doctorId)
        {
            PetId = petId;
            DoctorId = doctorId;
        }

        public abstract void Output();
    }
}