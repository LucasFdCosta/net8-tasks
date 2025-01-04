namespace Tasks.Communication.Responses;

public class ResponseGetAllTasksJson
{
    public List<ResponseShortTaskJson> Tasks { get; set; } = [];
}