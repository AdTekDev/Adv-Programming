namespace DP;

public class Singleton {
    private static Singleton instance;

    public string SingName {get; set;}

    public Singleton() {
        SingName = "";
    }

    
    public static Singleton Instance {
        get {
            if (instance == null) {
                //lock(instance) {
                    if (instance == null) {
                        instance = new Singleton();
                    }
                //}
            }
            return instance;
        }
    }

}