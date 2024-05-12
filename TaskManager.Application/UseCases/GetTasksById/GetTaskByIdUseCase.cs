using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.GetTasksById;

public class GetTaskByIdUseCase
{
    public ResponseTaskJson GetById(int id)
    {
        return new ResponseTaskJson()
        {
            Id = 1,
            Name = "Task 1",
            Description = "Testando",
            Limit = new DateTime(2024, 5, 23),
            Status = Communication.Enums.TaskState.InProgress,
            Priority = Communication.Enums.TaskPriority.Medium
        };
    }
}
