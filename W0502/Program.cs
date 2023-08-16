using System;

Console.WriteLine("Composite Pattern DEMO !");

Composite banphim = new Composite("Ban Phim");
banphim.Add( new Composite("Key A") );
banphim.Add( new Composite("Key B") );

Composite manhinh = new Composite("Man hinh");
manhinh.Add( new Composite("LCD") );
manhinh.Add( new Composite("Cameras") );

Composite maytinh = new Composite("May Tinh");
maytinh.Add(banphim);
maytinh.Add(manhinh);

maytinh.Display(3);
