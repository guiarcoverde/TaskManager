using Microsoft.AspNetCore.Mvc;
using TaskManager.Application.UseCases.CreateTasks;
using TaskManager.Application.UseCases.DeleteTasks;
using TaskManager.Application.UseCases.GetAllTasks;
using TaskManager.Application.UseCases.GetTasksById;
using TaskManager.Application.UseCases.UpdateTasks;
using TaskManager.Communication.Requests;
using TaskManager.Communication.Responses;

namespace TaskManager.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TaskController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreateTaskJson), StatusCodes.Status201Created)]
    public IActionResult CreateTask([FromBody]RequestTaskJson request)
    {
        var response = new CreateTaskUseCase().CreateTask(request);
        return Ok(response);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
    public IActionResult GetTasks(int id)
    {
        var response = new GetTaskByIdUseCase().GetById(id);
        return Ok(response);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(204)]
    public IActionResult UpdateTask([FromRoute]int id, [FromBody] RequestTaskJson request)
    {
        new UpdateTaskUseCase().Execute(id, request);
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(204)]
    public IActionResult DeleteTask([FromRoute]int id)
    {
        new DeleteTaskUseCase().Delete(id);
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    public IActionResult GetAllTasks()
    {
        var response = new GetAllTasksUseCase().GetTasks();
        return Ok(response);
    }
}
