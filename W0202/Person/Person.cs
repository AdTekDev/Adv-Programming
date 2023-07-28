public class Person {
    public string FirstName { get; private set; }   
    public int Age { get; private set; }
    public Decimal Salary { 
        get { return this.salary; }
        private set {
            if (value < 460) 
                throw  new Exception("Invalid salary");
            this.salary = value;
     } }

    private Decimal salary;
    public void increaseSalary(Decimal amount) {
        Salary += amount;
    }
    public Person(string firstName, int age, Decimal salary=0) {
        this.FirstName = firstName;
        this.Age = age;
        this.Salary = salary;
    }
    public override string ToString() {
        return $"{this.FirstName} {this.Age}";
    }
}