using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tasks.Application.UseCases.Task.GetAll;
using Tasks.Application.UseCases.Task.GetById;
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
        public IActionResult Post([FromBody] string value)
        {
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
