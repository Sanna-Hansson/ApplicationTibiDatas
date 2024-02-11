

using ApplicationTibiDatas.Entities;
using ApplicationTibiDatas.Repositories;

namespace ApplicationTibiDatas.Services;

internal class CustomerService
{
    private readonly CustomerRepository _customerRepository;
    private readonly RoleService _roleService;
    private readonly AddressService _addressService;

    public CustomerService(CustomerRepository customerRepository, RoleService roleService, AddressService addressService)
    {
        _customerRepository = customerRepository;
        _roleService = roleService;
        _addressService = addressService;
    }

    //Create

    public CustomerEntity CreateCustomer(
        string firstName, string lastName, string email,
        string roleName, string streetName, string postalCode,
        string city)
    {
        var roleEntity = _roleService.CreateNewRoles(roleName);
        var addressEntity = _addressService.CreateNewAddress(streetName, postalCode, city);

        var customerEntity = new CustomerEntity
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            RoleId = roleEntity.Id,,
            AdressId = addressEntity.Id,
        };

        customerEntity = _customerRepository.Create(customerEntity);
        return customerEntity;
    }


    public CustomerEntity GetCustomerByNameOrEmail(string firstName, string lastName, string email)
    {
        var customerEntity = _customerRepository.Get(
            x => x.FirstName == firstName 
            && x.LastName == lastName
            && x.Email == email
                        );
        return customerEntity;

    }

    public CustomerEntity GetCustomerById(int id)
    {
        var customerEntity = _customerRepository.Get(x => x.Id == id);
        return customerEntity;

    }
    public IEnumerable<CustomerEntity> GetAllCustomers()
    {
        var customers = _customerRepository.GetEverything();
        return customers;
    }

    public CustomerEntity UpdateChosenCustomer(CustomerEntity customerEntity)
    {
        var updateChosenCustomer = _customerRepository.Update(x => x.Id == customerEntity.Id, customerEntity);
        return updateChosenCustomer;
    }

    public void RemoveCustomer(int id)
    {
        _customerRepository.Delete(x => x.Id == id);

    }



}
