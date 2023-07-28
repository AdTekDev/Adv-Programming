
List<Person>  dsNhanVien = new List<Person>();

Console.WriteLine("Ban muon nhap thong tin bao nhieu NV: "); 
int lines = int.Parse(Console.ReadLine());
int i;

for(i=0; i<lines; i++) {
    Console.WriteLine($"Nhap nguoi thu {i}:  ");
    var tt = Console.ReadLine().Split();
    dsNhanVien.Add(new Person(tt[0], int.Parse(tt[1]), 700));
}

for(i=0; i<lines; i++) {
    Console.WriteLine($"[{i}] {dsNhanVien[i].ToString()} ");  
}  

var sorted = dsNhanVien.OrderBy(p => p.FirstName).ThenBy(p => p.Age).ToList();

Console.WriteLine(string.Join("\n ", sorted));