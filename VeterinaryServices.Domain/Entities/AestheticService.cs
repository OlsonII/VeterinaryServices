using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public class AestheticService : VeterinaryService
    {
        public AestheticServiceState State { get; set; }
        
        public new void Input(long petId, long doctorId)
        {
            State = AestheticServiceState.InProgress;
            base.Input(petId, doctorId);
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