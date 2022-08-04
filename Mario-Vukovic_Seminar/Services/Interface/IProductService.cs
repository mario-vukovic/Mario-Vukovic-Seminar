using Mario_Vukovic_Seminar.Models.Binding;
using Mario_Vukovic_Seminar.Models.Dbo;
using Mario_Vukovic_Seminar.Models.ViewModel;

namespace Mario_Vukovic_Seminar.Services.Interface;

public interface IProductService
{
    Task<List<ProductViewModel>> GetCategoryProductsAsync(int productCategoryId);
    Task<ProductViewModel> GetProductAsync(int id);
    Task<ProductViewModel> CreateProductAsync(ProductBinding model);
    Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model);
    Task DeleteProductAsync(Product model);
    Task<ProductCategoryViewModel> GetProductCategoryAsync(int id);
    Task<List<ProductCategoryViewModel>> GetAllProductCategoriesAsync();
    Task<ProductCategoryViewModel> CreateProductCategoryAsync(ProductCategoryBinding model);
    Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model);
    Task DeleteProductCategoryAsync(ProductCategory model);
    Task<List<ProductViewModel>> GetProductsAsync();
}