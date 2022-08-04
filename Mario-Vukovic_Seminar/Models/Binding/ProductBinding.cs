using Mario_Vukovic_Seminar.Models.Base;

namespace Mario_Vukovic_Seminar.Models.Binding
{
    public class ProductBinding : ProductBase
    {
        public int ProductCategoryId { get; set; }
        public IFormFile ProductImg { get; set; }
    }
}
