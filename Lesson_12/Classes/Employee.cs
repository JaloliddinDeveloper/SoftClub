namespace Lesson_12.Classes
{
    internal class Employee : Person
    {
        private decimal getSolary;
        public decimal GetSolary
        {
            get { return getSolary; }
            set { getSolary = value; }
        }

        public Employee(string name, int age, decimal solary)
            : base(name, age)
        {
            this.GetSolary = getSolary;
            this.GetSolary = solary;
        }

        public void GetSolaryInfo()
        {
            Console.WriteLine($"Employee name: {this.Name} Age: {Age} Salary: {GetSolary}");
        }

        public void SetSolaryInfo(decimal setSolary)
        {
            GetSolary = setSolary;
        }

        public void GetEmployeeInfo()
        {
            Console.WriteLine(
                $"""
                Name:{base.Name}
                Age:{base.Age}
                Salary:{GetSolary}
                """
                );
        }
    }
}
