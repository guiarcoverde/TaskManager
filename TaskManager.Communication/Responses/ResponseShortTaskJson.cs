namespace TaskManager.Communication.Responses;

public class ResponseShortTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public DateTime Limit {  get; set; }
}
