public class ProductPrototype : Prototype {

    public ProductPrototype(string id) : base(id) { }

    public override Prototype Clone() {
        return (Prototype) this.MemberwiseClone();
    }

    
}
