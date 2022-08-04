using AutoMapper;
using Mario_Vukovic_Seminar.Data;
using Mario_Vukovic_Seminar.Models.Binding;
using Mario_Vukovic_Seminar.Models.Dbo;
using Mario_Vukovic_Seminar.Models.ViewModel;
using Mario_Vukovic_Seminar.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace Mario_Vukovic_Seminar.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext db;
        private readonly IMapper mapper;
        private readonly IFileStorageService fileStorageService;

        public ProductService(IMapper mapper, ApplicationDbContext db, IFileStorageService fileStorageService)
        {
            this.mapper = mapper;
            this.db = db;
            this.fileStorageService = fileStorageService;
        }

        public async Task<List<ProductViewModel>> GetProductsAsync()
        {
            var products = await db.Product
                .Include(x => x.ProductCategory)
                .ToListAsync();

            return products.Select(x => mapper.Map<ProductViewModel>(x)).ToList();
        }

        public async Task<List<ProductViewModel>> GetCategoryProductsAsync(int productCategoryId)
        {
            var products = await db.Product
                .Include(x => x.ProductCategory)
                .Where(x => x.ProductCategory.Id == productCategoryId)
                .ToListAsync();

            return products.Select(x => mapper.Map<ProductViewModel>(x)).ToList();
        }

        public async Task<ProductViewModel> GetProductAsync(int id)
        {
            var product = await db.Product.Include(x => x.ProductCategory).FirstOrDefaultAsync(x => x.Id == id);
            return mapper.Map<ProductViewModel>(product);
        }

        public async Task<ProductViewModel> CreateProductAsync(ProductBinding model)
        {
            var productCategory = await db.ProductCategory.FirstOrDefaultAsync(x => x.Id == model.ProductCategoryId);
            var product = mapper.Map<Product>(model);
            if (model.ProductImg != null)
            {
                var fileResponse = await fileStorageService.AddFileToStorage(model.ProductImg);
                if (fileResponse != null)
                {
                    product.ProductImgUrl = fileResponse.DownloadUrl;
                }
            }
            product.ProductCategory = productCategory;
            db.Product.Add(product);
            await db.SaveChangesAsync();
            return mapper.Map<ProductViewModel>(product);
        }

        public async Task<ProductViewModel> UpdateProductAsync(ProductUpdateBinding model)
        {
            var productCategory = await db.ProductCategory.FirstOrDefaultAsync(x => x.Id == model.ProductCategoryId);
            var product = await db.Product.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (model.ProductImg != null)
            {
                var fileResponse = await fileStorageService.AddFileToStorage(model.ProductImg);
                if (fileResponse.FileName != null)
                {
                    product.ProductImgUrl = fileResponse.DownloadUrl;
                }
            }
            product.Name = model.Name ?? product.Name;
            product.Description = model.Description ?? product.Description;
            product.Quantity = model.Quantity;
            product.Price = model.Price;
            product.ProductCategory = productCategory;
            await db.SaveChangesAsync();
            return mapper.Map<ProductViewModel>(product);
        }

        public async Task DeleteProductAsync(Product model)
        {
            var product = await db.Product.FirstOrDefaultAsync(x => x.Id == model.Id);
            db.Product.Remove(product);
            await db.SaveChangesAsync();
        }
        public async Task<ProductCategoryViewModel> GetProductCategoryAsync(int id)
        {
            var productCategory = await db.ProductCategory.FindAsync(id);
            return mapper.Map<ProductCategoryViewModel>(productCategory);
        }
        public async Task<List<ProductCategoryViewModel>> GetAllProductCategoriesAsync()
        {
            var productCategories = await db.ProductCategory.ToListAsync();
            return productCategories.Select(x => mapper.Map<ProductCategoryViewModel>(x)).ToList();
        }

        public async Task<ProductCategoryViewModel> CreateProductCategoryAsync(ProductCategoryBinding model)
        {
            var productCategory = mapper.Map<ProductCategory>(model);
            db.ProductCategory.Add(productCategory);
            await db.SaveChangesAsync();
            return mapper.Map<ProductCategoryViewModel>(productCategory);
        }

        public async Task<ProductCategoryViewModel> UpdateProductCategoryAsync(ProductCategoryUpdateBinding model)
        {
            var productCategory = await db.ProductCategory.FirstOrDefaultAsync(x => x.Id == model.Id);
            mapper.Map(model, productCategory);
            await db.SaveChangesAsync();
            return mapper.Map<ProductCategoryViewModel>(productCategory);
        }

        public async Task DeleteProductCategoryAsync(ProductCategory model)
        {
            var productCategory = await db.ProductCategory.FirstOrDefaultAsync(x => x.Id == model.Id);
            db.ProductCategory.Remove(productCategory);
            await db.SaveChangesAsync();
        }
    }
}
