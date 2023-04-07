namespace w020201school
{
    public class Employee : Person {
        public string Company {get; set;}

        public Employee(string ten, string diachi, string tencongty) {
            this.Address = diachi;
            this.Name = ten;
            this.Company = tencongty;
        }
    }
}