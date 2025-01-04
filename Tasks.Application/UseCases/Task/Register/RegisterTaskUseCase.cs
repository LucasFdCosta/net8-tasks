using Tasks.Communication.Enums;
using Tasks.Communication.Requests;
using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Task.Register;

public class RegisterTaskUseCase
{
    public ResponseTaskJson Execute(RequestTaskJson task)
    {
        return new ResponseTaskJson()
        {
            Id = 1,
            Name = task.Name,
            Description = task.Description,
            Deadline = task.Deadline,
            Priority = task.Priority,
            Status = task.Status,
        };
    }
}