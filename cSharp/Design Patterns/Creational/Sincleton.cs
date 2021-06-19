
public class Singleton
{
    //Singleton class works with an internal class of itself.
    private static Singleton instance = null;
    public string message;

    protected Singleton(string message = null)
    {
        this.message = message != null ? message : "";
    }
    public static Singleton Instance
    {
        get
        {
            if (instance == null)
                instance = new Singleton();

            return instance;
        }

    }

}