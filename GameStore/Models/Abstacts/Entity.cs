namespace Models.Abstacts
{
    public abstract class Entity<T>
    {
        public T Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
