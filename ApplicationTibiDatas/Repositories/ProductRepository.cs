

using ApplicationTibiDatas.Contexts;
using ApplicationTibiDatas.Entities;

namespace ApplicationTibiDatas.Repositories;

internal class ProductRepository : Repo<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}

