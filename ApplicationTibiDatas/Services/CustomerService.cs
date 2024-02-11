

using ApplicationTibiDatas.Repositories;

namespace ApplicationTibiDatas.Services;

internal class CustomerService
{
    private readonly CustomerRepository _customerRepository;

    public CustomerService(CustomerRepository customerRepository)
    {
        _customerRepository = customerRepository;
    }






}
