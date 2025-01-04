using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tasks.Application.UseCases.Task.Delete;
using Tasks.Application.UseCases.Task.GetAll;
using Tasks.Application.UseCases.Task.GetById;
using Tasks.Application.UseCases.Task.Register;
using Tasks.Application.UseCases.Task.Update;
using Tasks.Communication.Requests;
using Tasks.Communication.Responses;

namespace Tasks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(typeof(List<ResponseShortTaskJson>), StatusCodes.Status200OK)]
        public IActionResult Get()
        {
            var useCase = new GetAllTasksUseCase();
            
            var tasks = useCase.Execute();
            
            return Ok(tasks);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult GetById(int id)
        {
            var useCase = new GetTaskByIdUseCase();
            
            var task = useCase.Execute(id);
            
            return Ok(task);
        }

        [HttpPost]
        [ProducesResponseType(typeof(ResponseTaskJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody] RequestTaskJson request)
        {
            var useCase = new RegisterTaskUseCase();
            
            var task = useCase.Execute(request);

            return Created(string.Empty, task);
        }

        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
        public IActionResult Put(int id, [FromBody] RequestTaskJson request)
        {
            var useCase = new UpdateTaskUseCase();
            
            useCase.Execute(id, request);
            
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status404NotFound)]
        public IActionResult Delete(int id)
        {
            var useCase = new DeleteTaskUseCase();
            
            useCase.Execute(id);
            
            return NoContent();
        }
    }
}
