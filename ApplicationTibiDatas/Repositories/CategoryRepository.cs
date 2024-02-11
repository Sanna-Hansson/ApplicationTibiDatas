

using ApplicationTibiDatas.Contexts;
using ApplicationTibiDatas.Entities;

namespace ApplicationTibiDatas.Repositories;

internal class CategoryRepository : Repo<CategoryEntity>
{
    public CategoryRepository(DataContext context) : base(context)
    {
    }
}

