public class Employee : Person {
    public String Company { get; set; }

    public Employee(String iname, String iaddress, String company) :
        base(iname, iaddress) 
    {
        this.Company = company;
    }

    public void Work() {
        Console.WriteLine($"{this.Name} lam viec tai {this.Company}");
    }
}

