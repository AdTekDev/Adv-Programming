public abstract class Prototype {
    private string _id;

    public Prototype(string id) {
        this._id = id;
    }

    public string Id  => this._id;

    public void setId(string id) {
        this._id = id;
    }

    public abstract Prototype Clone(); 
}

