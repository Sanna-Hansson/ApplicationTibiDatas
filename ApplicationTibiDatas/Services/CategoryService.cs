

using ApplicationTibiDatas.Entities;
using ApplicationTibiDatas.Repositories;

namespace ApplicationTibiDatas.Services;

internal class CategoryService
{
    private readonly CategoryRepository _categoryRepository;

    public CategoryService(CategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public CategoryEntity CreateCategory(string categoryName)
    {
        var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);

        categoryEntity ??= _categoryRepository.Create(new CategoryEntity { CategoryName = categoryName });

        return categoryEntity;
    }

    public CategoryEntity GetCategoryByCategoryName(string categoryName)
    {
        var categoryEntity = _categoryRepository.Get(x => x.CategoryName == categoryName);
        return categoryEntity;

    }

    public CategoryEntity GetCategoryById(int id)
    {
        var categoryEntity = _categoryRepository.Get(x => x.Id == id);
        return categoryEntity;

    }
    public IEnumerable<CategoryEntity> GetAllCategories()
    {
        var categories = _categoryRepository.GetEverything();
        return categories;
    }

    public CategoryEntity UpdateChosenCategory (CategoryEntity categoryEntity)
    {
        var updateChosenCategory = _categoryRepository.Update(x=> x.Id == categoryEntity.Id, categoryEntity);
        return updateChosenCategory;
    }

    public void RemoveCategory( int id)
    {
        _categoryRepository.Delete(x=> x.Id == id);

    }

}
