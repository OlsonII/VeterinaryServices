using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public class AestheticService : VeterinaryService
    {
        public AestheticServiceState State { get; set; }
        
        public new void Input(Pet pet, Doctor doctor)
        {
            State = AestheticServiceState.InProgress;
            base.Input(pet, doctor);
        }
        
        public void Start()
        {
            State = AestheticServiceState.InProgress;
        }
        
        public override void Output()
        {
            State = AestheticServiceState.Completed;
        }

        public void Cancel()
        {
            State = AestheticServiceState.Canceled;
        }
    }
}