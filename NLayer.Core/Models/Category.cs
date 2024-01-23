namespace NLayer.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        //category can have more than one product
        //navigation property:
        public ICollection<Product> Products { get; set; }
    }
}
