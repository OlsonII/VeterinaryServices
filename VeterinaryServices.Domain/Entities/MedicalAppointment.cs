using System.Collections.Generic;
using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public class MedicalAppointment : VeterinaryService
    {
        public string Observation { get; set; }
        //TODO: MORE TIME TO THIS
        // public Dictionary<string, int> Prescription { get; set; }
        public MedicalAppointmentState State { get; set; }

        public new void Input(long petId, long doctorId)
        {
            State = MedicalAppointmentState.Pending;
            base.Input(petId, doctorId);
        }
        
        public override void Output()
        {
            State = MedicalAppointmentState.Completed;
        }

        public void Cancel()
        {
            State = MedicalAppointmentState.Canceled;
        }
    }
}