public class Student : Person {
    public string School { get; set; }

    public Student(string iname, string iaddress, string school) :
        base (iname, iaddress)
    {        
        this.School = school;
    }

    public void Study() {
        Console.WriteLine($"{this.Name} hoc tai {this.School}");
    }
}

