using System;
using Core.Entities;
using Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class HydraStoreContext(DbContextOptions options) : DbContext (options)
{
    public DbSet<Product> Products {get; set;}
    public DbSet<Category> Categories {get; set;}
    public DbSet<Document> Documents {get; set;}
    public DbSet<Producer> Producers {get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(OfferProductConfiguration).Assembly);
    }
}
