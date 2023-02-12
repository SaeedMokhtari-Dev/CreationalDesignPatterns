namespace Singleton;

public class Singleton
{
    private static Singleton? _singleton;
    public readonly string Guid;
    private Singleton()
    {
        Guid = System.Guid.NewGuid().ToString();
    }

    public static Singleton GetInstance()
    {
        if (_singleton == null)
            _singleton = new Singleton();
        return _singleton;
    }
}