// See https://aka.ms/new-console-template for more information
using w010201;

Console.WriteLine("Chuong trinh Quan ly Lop hoc va Sinh Vien");


StdClass cls = new StdClass("Adv Programming");

cls.addStudent(new Student("A", "Phu", 300));
cls.addStudent(new Student("AKa", "Phung", 300));
cls.addStudent(new Student("AMa", "Phuc", 300));
cls.addStudent(new Student("A", "Phung", 300));


cls.showStdList();


cls.showStdList("A");