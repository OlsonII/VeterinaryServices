using System;

namespace VeterinaryServices.Domain.Base
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}