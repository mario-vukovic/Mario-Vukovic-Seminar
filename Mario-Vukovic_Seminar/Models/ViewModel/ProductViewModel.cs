using Mario_Vukovic_Seminar.Models.Base;

namespace Mario_Vukovic_Seminar.Models.ViewModel
{
    public class ProductViewModel : ProductBase
    {
        public int Id { get; set; }
        public ProductCategoryViewModel ProductCategory { get; set; }
    }
}
