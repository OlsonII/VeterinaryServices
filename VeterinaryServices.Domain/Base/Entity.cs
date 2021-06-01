namespace VeterinaryServices.Domain.Base
{
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Identification { get; set; }
    }
}