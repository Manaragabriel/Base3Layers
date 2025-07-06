namespace ApplicationCore.Entities.shared;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public string Guid { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime ModificationDate { get; set; }
    public bool IsDeleted { get; set; }

}