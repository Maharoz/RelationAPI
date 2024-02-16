namespace MasjidLibraryAPI.Models
{
    public class Parent
    {
        public int Id { get; set; }
        // Other parent properties...

        public List<Child> Children { get; set; }
    }

    // Child.cs
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ParentId { get; set; }

        public Parent Parent { get; set; }
    }
}
