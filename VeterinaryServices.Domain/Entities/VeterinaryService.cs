using System;
using VeterinaryServices.Domain.Base;

namespace VeterinaryServices.Domain.Entities
{
    public abstract class VeterinaryService : Entity<long>, IVeterinaryService
    {
        public Doctor Doctor { get; set; }
        public Pet Pet { get; set; }
        public DateTime Date { get; set; }
        public double Cost { get; set; }

        public void Input(Pet pet, Doctor doctor)
        {
            Pet = pet;
            Doctor = doctor;
        }

        public abstract void Output();
    }
}