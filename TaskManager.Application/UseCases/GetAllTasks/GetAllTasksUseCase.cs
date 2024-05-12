using TaskManager.Communication.Responses;

namespace TaskManager.Application.UseCases.GetAllTasks;

public class GetAllTasksUseCase
{
    public ResponseAllTasksJson GetTasks()
    {
        return new ResponseAllTasksJson()
        {
            Tasks =
            [
                new() {
                    Name = "Lavar Pratos",
                    Description = "Lavar os pratos da casa",
                    Limit = new DateTime(2024, 05, 15)
                },

                new() {
                    Name = "Passear com o cachorro",
                    Description = "Levar o cachorro para passear no bairro",
                    Limit = new DateTime(2024, 05, 13)
                },

                new(){
                    Name = "Estudar",
                    Description = "Estudar C# na RocketSeat",
                    Limit = new DateTime(2024, 05, 14)
                }     
            ]
        };
    }
}
