

using ApplicationTibiDatas.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApplicationTibiDatas.Contexts;

internal class DataContext : DbContext
{
    public DataContext(DbContextOptions <DataContext> options) : base(options)
    {

    }

    public DbSet <AdressEntity> Adresses { get; set; }

    public DbSet <CategoryEntity> Categories { get; set; }

    public DbSet <CustomerEntity> Customers { get; set; }

    public DbSet <ProductEntity> Products { get; set; }

    public DbSet <RoleEntity> Roles { get; set; }


}
