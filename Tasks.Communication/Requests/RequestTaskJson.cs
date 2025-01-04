using Tasks.Communication.Enums;

namespace Tasks.Communication.Requests;

public class RequestTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public Priority Priority { get; set; }
    public DateTime Deadline { get; set; } = DateTime.Today.AddDays(30);
    public Status Status { get; set; }
}