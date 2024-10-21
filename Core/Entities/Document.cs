using System;

namespace Core.Entities;

public class Document : BaseEntity
{
    public required string Name { get; set; }
    public required string DocumentUrl { get; set; }
    public int ProductId { get; set; }
    public virtual Product? Product{ get; set; }
}
