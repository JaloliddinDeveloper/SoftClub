namespace Exam_2.ClassesOne
{
    internal class Staff
    {
        private string school;
        private double pay;

        public Staff(string school, double pay)
        {
            this.school = school;
            this.pay = pay;
        }

        public string GetSchool()=>
             this.school;

        public void SetSchool(string school)=>
             this.school = school; 
        
        public double GetPay()=>
            this.pay;

        public void SetPay(double pay) =>
            this.pay = pay;

        public override string ToString()=>
             $"School: {school} Pay: {pay}";
    }
}
