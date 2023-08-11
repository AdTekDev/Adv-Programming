
Console.WriteLine("Demo cac Design Patterns!");

ProductPrototype product = new ProductPrototype("Hang Fake");

ProductPrototype product02 = product.Clone() as ProductPrototype;

Console.WriteLine($" {product.Id}  {product02.Id}");

product.setId("H 01");
product02.setId("H 02");
Console.WriteLine($" {product.Id}  {product02.Id}");

/*
SingleObject x = SingleObject.getInstance();
SingleObject y = SingleObject.getInstance();
SingleObject z = SingleObject.getInstance();

x.State = "chua co gi!";
y.State = "co gi chua!";


Console.WriteLine($"{x.State} {y.State} {z.State}");
*/