using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public class Hospitalization : VeterinaryService
    {
        public string Observation { get; set; }
        public HospitalizationState State { get; set; }
        
        public new void Input(long petId, long doctorId)
        {
            State = HospitalizationState.InProgress;
            base.Input(petId, doctorId);
        }
        
        public override void Output()
        {
            State = HospitalizationState.Completed;
        }
    }
}