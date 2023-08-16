
public abstract class  AComponent {
    protected string name;
    public AComponent(string name) {
        this.name = name;
    }
    public abstract void Add(AComponent component);
    public abstract void Remove(AComponent component);
    public abstract void Display(int depth, string str = "");
}