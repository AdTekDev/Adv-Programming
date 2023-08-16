
using System;

public class Composite : AComponent {

    private List<AComponent> _children = new List<AComponent>();
    public Composite(string name) : base(name) 
    { }
    public override void Add(AComponent component)
    {
        _children.Add(component);
    }
    public override void Remove(AComponent component)
    {
        _children.Remove(component);
    }
    public override void Display(int depth, string str = "")
    {
        Console.WriteLine(str + this.name);
        if (depth > 0 && _children.Count > 0) {
            foreach (var child in _children) {
                child.Display(depth-1, str + "\t");
            }
        }
    }

}
