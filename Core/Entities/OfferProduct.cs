using System;

namespace Core.Entities;

public class OfferProduct : BaseEntity
{
    public int OfferId { get; set; }
    public virtual Offer? Offer { get; set; }
    public int ProductId { get; set; }
    public virtual Product? Product { get; set; }
    public decimal Quantity { get; set; }
    public decimal Price { get; set; }
}
