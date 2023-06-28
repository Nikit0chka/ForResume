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
    public bool IsActive { get; set; }
}

public class Command
{
    public int Id { get; set; }
    public Mode Mode { get; set; }
    public int ModeId { get; set; }
    public Device Device { get; set; }
    public int DeviceId { get; set; }
    public string Action { get; set; }
}