namespace Mario_Vukovic_Seminar.Models.Base
{
    public abstract class ProductBase
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public string? ProductImgUrl { get; set; }

    }
}
