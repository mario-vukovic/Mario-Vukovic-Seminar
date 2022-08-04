using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mario_Vukovic_Seminar.Models.Base;
using Mario_Vukovic_Seminar.Models.Dbo.Base;

namespace Mario_Vukovic_Seminar.Models.Dbo
{
    public class ProductCategory : ProductCategoryBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey("ProductCategory")]
        public int ProductId { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
