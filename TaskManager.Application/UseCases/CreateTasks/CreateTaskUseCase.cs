using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.CreateTasks;

public class CreateTaskUseCase
{
    public ResponseCreateTaskJson CreateTask(RequestTaskJson request)
    {
        return new ResponseCreateTaskJson()
        {
            Name = request.Name,
            Description = request.Description
        };
    }
}
