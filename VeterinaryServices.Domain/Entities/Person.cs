using VeterinaryServices.Domain.Base;
using VeterinaryServices.Domain.Enums;

namespace VeterinaryServices.Domain.Entities
{
    public abstract class Person : Entity<long>
    {
        public string Names { get; set; }
        public string Surnames { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
    }
}