using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Mario_Vukovic_Seminar.Models.Base;
using Mario_Vukovic_Seminar.Models.Dbo.Base;

namespace Mario_Vukovic_Seminar.Models.Dbo
{
    public class Product : ProductBase, IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public DateTime Created { get; set; }
        [ForeignKey("Product")]
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
