namespace w020201school
{
    public class Person {
        public string Name {get; set;}
        public string Address {get; set;}

        public Person mother {get; set;}
        public Person father {get; set;}

        public void sleep() {
            Console.Write(this.Name + " sleep !");
        }
    }
}