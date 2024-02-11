

using ApplicationTibiDatas.Contexts;
using ApplicationTibiDatas.Entities;

namespace ApplicationTibiDatas.Repositories;

internal class RoleRepository : Repo<RoleEntity>
{
    public RoleRepository(DataContext context) : base(context)
    {
    }
}

