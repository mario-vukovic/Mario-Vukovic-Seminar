using Mario_Vukovic_Seminar.Models.Base;

namespace Mario_Vukovic_Seminar.Models.Binding
{
    public class ProductCategoryBinding : ProductCategoryBase
    {

    }

    public class ProductCategoryUpdateBinding : ProductCategoryBinding
    {
        public int Id { get; set; }
    }
}
