public class Person {
    public string Name { get; set; }
    public string Address { get; set; }

    public Person(string name, string address) {
        this.Name = name;
        this.Address = address;
    }
    public void sleep() {
        Console.WriteLine($"{Name} di ngu !");
    }
}
