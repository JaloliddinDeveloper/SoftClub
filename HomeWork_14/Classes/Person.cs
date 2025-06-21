namespace HomeWork_14.Classes
{
    internal class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public virtual string GetDetails()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
