namespace OMPS.DomainKatmani.Abstractions
{
    /// <summary>
    /// Hemen her tabloda olucak özelikler için ortak alan
    /// </summary>
    public abstract class Entity
    {
        public Entity()
        {
        }

        public Entity(string ıd)
        {
            Id = ıd;
        }

        public string Id { get; set; } = Guid.NewGuid().ToString();
        public DateTime CreatedDate { get; set; } 
        public DateTime? UpdatedDate { get; set; }

    }
}
