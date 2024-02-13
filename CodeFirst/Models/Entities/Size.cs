namespace CodeFirst.Entities.Size
{
    public class Size
    {
#nullable disable
        public int Id { get; set; }
        public string Name { get; set; }
        public string SmallName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime DeletedAt { get; set; }
        public int DeletedBy { get; set; }
        public bool IsDeleted { get; set; }
#nullable enable
    }
}
