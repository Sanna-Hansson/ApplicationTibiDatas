

using ApplicationTibiDatas.Contexts;
using ApplicationTibiDatas.Entities;
using System.Linq.Expressions;

namespace ApplicationTibiDatas.Repositories;

internal class CustomerRepository : Repo<CustomerEntity>
{
    public CustomerRepository(DataContext context) : base(context)
    {
    }

    public override CustomerEntity Get(Expression<Func<CustomerEntity, bool>> expression)
    {
        return base.Get(expression);
    }

    public override IEnumerable<CustomerEntity> GetEverything()
    {
        return base.GetEverything();
    }
}

