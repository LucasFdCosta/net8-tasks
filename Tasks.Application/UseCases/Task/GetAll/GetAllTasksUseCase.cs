using Tasks.Communication.Responses;

namespace Tasks.Application.UseCases.Task.GetAll;

public class GetAllTasksUseCase
{
    public ResponseGetAllTasksJson Execute()
    {
        var tasks = new ResponseGetAllTasksJson()
        {
            Tasks = new List<ResponseShortTaskJson>()
            {
                new ResponseShortTaskJson()
                {
                    Id = 1,
                    Name = "Task1",
                    Description = "Task1",
                    Deadline = DateTime.Now.AddDays(30),
                },
                new ResponseShortTaskJson()
                {
                    Id = 2,
                    Name = "Task2",
                    Description = "Task2",
                    Deadline = DateTime.Now.AddDays(15),
                },
                new ResponseShortTaskJson()
                {
                    Id = 3,
                    Name = "Task3",
                    Description = "Task3",
                    Deadline = DateTime.Now.AddDays(20),
                }
            }
        };

        return tasks;
    }
}