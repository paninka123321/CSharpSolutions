namespace Classes
{
    public class CustomerWithConstructorExample
    {
        public int Id;
        public string Name;

        // Constructor with parameters
        public CustomerWithConstructorExample(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        // overloading constructors
        public CustomerWithConstructorExample(string name)
        {
            this.Name = name;

        }
        // Default constructor
        public CustomerWithConstructorExample()
        {
            this.Id = 0;
            this.Name = "Default Name";
        }
    }
}