// See https://aka.ms/new-console-template for more information
using w010201;

Console.WriteLine("Chuong trinh Quan ly Lop hoc va Sinh Vien");


StdClass cls = new StdClass("Adv Programming");

cls.addStudent(new Student("A", "Phu", 300, 6));
cls.addStudent(new Student("AKa", "Phung", 30, 6));
cls.addStudent(new Student("AMa", "Phuc", 35, 8));
cls.addStudent(new Student("A", "Phung", 50, 7));


cls.showStdList();


cls.showStdList("A");



cls.showStdList(50, 7);