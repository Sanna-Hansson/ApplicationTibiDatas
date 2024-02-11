

using ApplicationTibiDatas.Contexts;
using ApplicationTibiDatas.Entities;

namespace ApplicationTibiDatas.Repositories;

internal class AddressRepository : Repo<AdressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}

