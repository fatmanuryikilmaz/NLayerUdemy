namespace NLayer.Core.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        //every single product has one category
        public Category Category { get; set; }
        //you can show if can take a null with a question mark in the end "?"

        //application can work with or without ? mark
        //you should use nullable feature for referance types
        //or you can close the null check from properties of the core layer
        public ProductFeature ProductFeature { get; set; }

    }
}
