using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Requests;

public class RequestTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TaskPriority Priority { get; set; }
    public TaskState Status { get; set; }
    public DateTime Limit {  get; set; }
}
