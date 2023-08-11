public class SingleObject {
    public static  SingleObject instance=null;
    static string flag="Flag";
    public string State { get; set; }

    private SingleObject() { }

    public static SingleObject getInstance() 
    { 
        if (instance==null)
        lock (flag) {
            if (instance==null) {
                instance = new SingleObject();
            }
        } 
        return instance; 
    }  
}