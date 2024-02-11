

using ApplicationTibiDatas.Entities;
using ApplicationTibiDatas.Repositories;

namespace ApplicationTibiDatas.Services;

internal class RoleService
{
    private readonly RoleRepository _roleRepository;

    public RoleService(RoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public RoleEntity CreateNewRoles(string roleName)
    {
        var roleEntity = _roleRepository.Get(
        x => x.RoleName == roleName       
        );

        roleEntity ??= _roleRepository.Create(new RoleEntity
        {
            RoleName = roleName           
        });

        return roleEntity;
    }

    public RoleEntity GetRole(string roleName, int id)
    {
        var roleEntity = _roleRepository.Get(
            x => x.RoleName == roleName 
                        );
        return roleEntity;

    }

    public RoleEntity GetRoleById(int id)
    {
        var roleEntity = _roleRepository.Get(x => x.Id == id);
        return roleEntity;

    }
    public IEnumerable<RoleEntity> GetAllRoles()
    {
        var roles = _roleRepository.GetEverything();
        return roles;
    }

    public RoleEntity UpdateChosenRole(RoleEntity roleEntity)
    {
        var updateChosenRole = _roleRepository.Update(x => x.Id == roleEntity.Id, roleEntity);
        return updateChosenRole;
    }

    public void RemoveRole(int id)
    {
        _roleRepository.Delete(x => x.Id == id);

    }




}
