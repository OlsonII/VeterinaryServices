using System;

namespace VeterinaryServices.Domain.Entities
{
    public interface IVeterinaryService
    {
        Doctor Doctor { get; set; }
        Pet Pet { get; set; }
        DateTime Date { get; set; }
        Double Cost { get; set; }
        void Input(Pet pet, Doctor doctor);
        void Output();
    }
}