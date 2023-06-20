namespace DataBaseModel;

public class Device
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Mode> Modes { get; set; }
}

public class Mode
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsOn { get; set; }
}