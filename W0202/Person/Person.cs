public class Person {
    public string FirstName { get; private set; }   
    public int Age { get; private set; }

    public Person(string firstName, int age) {
        this.FirstName = firstName;
        this.Age = age;
    }
    public override string ToString() {
        return $"{this.FirstName} {this.Age}";
    }
}