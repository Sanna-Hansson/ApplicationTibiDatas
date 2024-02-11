

using ApplicationTibiDatas.Contexts;
using ApplicationTibiDatas.Entities;

namespace ApplicationTibiDatas.Repositories;

internal class CustomerRepository : Repo<CustomerEntity>
{
    public CustomerRepository(DataContext context) : base(context)
    {
    }
}

