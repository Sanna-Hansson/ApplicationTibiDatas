

using ApplicationTibiDatas.Entities;
using ApplicationTibiDatas.Repositories;

namespace ApplicationTibiDatas.Services;

internal class AddressService
{
    private readonly AddressRepository _addressRepository;

    public AddressService(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository;
    }

    public AdressEntity CreateNewAddress(string streetName, string postalCode, string city )
    {
        var addressEntity = _addressRepository.Get(
        x => x.StreetName == streetName 
        && x.PostalCode == postalCode
        && x.City == city         
        );

        addressEntity ??= _addressRepository.Create(new AdressEntity
        { 
            StreetName = streetName,
            PostalCode = postalCode, 
            City = city
        });

        return addressEntity;
    }

    public AdressEntity GetAddress(string streetName, string postalCode, string city)
    {
        var addressEntity = _addressRepository.Get(
            x => x.StreetName == streetName 
            && x.PostalCode == postalCode 
            && x.City == city);
        return addressEntity;

    }

    public AdressEntity GetAddressById(int id)
    {
        var addressEntity = _addressRepository.Get(x => x.Id == id);
        return addressEntity;

    }
    public IEnumerable<AdressEntity> GetAllAddresses()
    {
        var addresses = _addressRepository.GetEverything();
        return addresses;
    }

    public AdressEntity UpdateChosenAddress(AdressEntity addressEntity)
    {
        var updateChosenAddress= _addressRepository.Update(x => x.Id == addressEntity.Id, addressEntity);
        return updateChosenAddress;
    }

    public void RemoveAddress(int id)
    {
        _addressRepository.Delete(x => x.Id == id);

    }




}
