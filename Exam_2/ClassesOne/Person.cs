namespace Exam_2.ClassesOne
{
    internal class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string GetName()=>
             name;

        public string GetAddress()=>
            address;

        public void SetAddress(string address)
            => this.address = address;
        
    }
}
