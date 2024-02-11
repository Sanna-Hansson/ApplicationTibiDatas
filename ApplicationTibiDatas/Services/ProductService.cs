
using ApplicationTibiDatas.Entities;
using ApplicationTibiDatas.Repositories;

namespace ApplicationTibiDatas.Services;

internal class ProductService
{
    private readonly ProductRepository _productRepository;

    private readonly CategoryService _categoryService;


    public ProductService(ProductRepository productRepository, CategoryService categoryService)
    {
        _productRepository = productRepository;
        _categoryService = categoryService;
    }

    //Create annorlunda
   public ProductEntity CreateProduct(string title, decimal price, string categoryName )
    {
        var categoryEntity = _categoryService.CreateCategory(categoryName);

        var productEntity = new ProductEntity
        {
            Title = title,
            Price = price,
            CategoryId = categoryEntity.Id,
        };

       productEntity =  _productRepository.Create(productEntity);
        return productEntity;

    }

   
    public ProductEntity GetProductById(int id)
    {
        var productEntity = _productRepository.Get(x => x.Id == id);
        return productEntity;

    }
    public IEnumerable<ProductEntity> GetAllProducts()
    {
        var products = _productRepository.GetEverything();
        return products;
    }

    public ProductEntity UpdateChosenRole(ProductEntity productEntity)
    {
        var updateChosenProduct = _productRepository.Update(x => x.Id == productEntity.Id, productEntity);
        return updateChosenProduct;
    }

    public void RemoveProduct(int id)
    {
        _productRepository.Delete(x => x.Id == id);

    }


}
