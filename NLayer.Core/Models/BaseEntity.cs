namespace NLayer.Core.Models
{
    public abstract class BaseEntity
    {
        //In abstract, you cannot create a new object with the 'new' keyword.You can use it for the common things
        //Abstract classes provide a way to define a common interface for a group of related classes while allowing each derived class to provide its own specific implementation. They are a key concept in object-oriented programming for achieving abstraction and polymorphism.
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
