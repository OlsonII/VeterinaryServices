using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public class Hospitalization : VeterinaryService
    {
        public string Observation { get; set; }
        public HospitalizationState State { get; set; }
        
        public new void Input(Pet pet, Doctor doctor)
        {
            State = HospitalizationState.InProgress;
            base.Input(pet, doctor);
        }
        
        public override void Output()
        {
            State = HospitalizationState.Completed;
        }
    }
}