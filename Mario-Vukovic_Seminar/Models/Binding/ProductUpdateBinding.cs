using Mario_Vukovic_Seminar.Models.Base;
using Mario_Vukovic_Seminar.Models.ViewModel;

namespace Mario_Vukovic_Seminar.Models.Binding
{
    public class ProductUpdateBinding : ProductBase
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }
        public IFormFile ProductImg { get; set; }
    }
}
