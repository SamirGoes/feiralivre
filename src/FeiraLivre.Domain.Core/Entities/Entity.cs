namespace FeiraLivre.Domain.Core.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public int Id { get; set; }

        public virtual bool Equals(Entity? other)
        {
            if(other == null) return false;
            
            return other?.Id == this.Id;
        }
    }
}