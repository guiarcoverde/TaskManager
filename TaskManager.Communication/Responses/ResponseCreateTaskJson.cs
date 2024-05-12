using TaskManager.Communication.Enums;

namespace TaskManager.Communication.Responses;

public class ResponseCreateTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
