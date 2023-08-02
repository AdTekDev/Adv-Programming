public class Employee : Person {
    public String Company { get; set; }

    public Employee(String iname, String iaddress, String company) :
        base(iname, iaddress) 
    {
        this.Company = company;
    }
}

