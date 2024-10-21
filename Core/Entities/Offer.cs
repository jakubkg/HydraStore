using System;

namespace Core.Entities;

public class Offer : BaseEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime ExpiryDate { get; set; }
    public required string CustomerName { get; set; }
    public required string Note { get; set; }
    public virtual List<OfferProduct>? Products { get; set;}

}
