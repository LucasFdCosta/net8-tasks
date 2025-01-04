using Tasks.Communication.Enums;
using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Task.GetById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson Execute(int id)
    {
        return new ResponseTaskJson()
        {
            Id = id,
            Name = $"Task {id}",
            Description = "Task description",
            Priority = Priority.Normal,
            Deadline = DateTime.Now.AddDays(30),
            Status = Status.Pending
        };
    }
}