namespace NLayer.Core.Models
{
    public class ProductFeature
    {
        //already connected to product.No need to connect to BaseEntity

        public int Id { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
