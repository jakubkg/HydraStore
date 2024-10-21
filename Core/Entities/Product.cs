using System;

namespace Core.Entities;

public class Product : BaseEntity
{
    public required string Number { get; set; }
    public required string Name { get; set; }
    public required string Description { get; set; }
    public decimal Price { get; set; }
    public required string PictureUrl { get; set; }
    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }
    public int ProducerId { get; set; }
    public virtual Producer? Producer { get; set; }
    public required int SystemProductId {get; set;}
    public decimal Pack { get; set; }
    public decimal QuantityInStock { get; set; }
    public bool OnlyInFullPackages {get; set;}
}
