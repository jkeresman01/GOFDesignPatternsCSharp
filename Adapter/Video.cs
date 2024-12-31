namespace Adapter;

public class Video
{
    private static int _idGenerator;
    private readonly int _id;
    
    public String Name { get; set; }

    public Video(string name)
    {
        _id = ++_idGenerator;
        Name = name;
    }

    public override string ToString() => $"Video: {Name} ({_id})";
}