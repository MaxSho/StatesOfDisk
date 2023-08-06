namespace StatesOfDisk.Domain.Common;

public abstract class BaseEntity
{
    //public Guid IdBase { get; set; }
    public string Id { get; set; }
    public DateTimeOffset DateCreated { get; set; }
    public DateTimeOffset? DateUpdated { get; set; }
    public DateTimeOffset? DateDeleted { get; set; }
}