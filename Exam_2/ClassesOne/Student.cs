namespace Exam_2.ClassesOne
{
    internal class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, string address, string propram, int year, double fee)
            : base(name, address)
        {
            this.program = propram;
            this.year = year;
            this.fee = fee;
        }

        public string GetProgram() =>
            this.program;

        public void SetProgram(string program) =>
           this.program = program;

        public int GetYear() => this.year;

        public void SetYear(int year) =>
            this.year = year;

        public double GetFee() =>
            this.fee;

        public void SetFee(double fee) =>
            this.fee = fee;

        public override string ToString() =>
            $"Program: {program} Year: {year} Fee: {fee}";
    }
}
