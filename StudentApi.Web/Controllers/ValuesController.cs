using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Core.Command;
using StudentApi.Core.Query;

namespace StudentApi.Web.Controllers
{
    [Route("api/students")]
    public class StudentsController : Controller
    {
        private readonly IMediator _mediator;

        public StudentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var students = await _mediator.Send(new GetAllStudentsQuery());
            return Ok(students);
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateStudentCommand command)
        {
            var result = await _mediator.Send(new CreateStudentCommand
            {
                GivenName = command?.GivenName,
                FamilyName = command?.FamilyName
            });

            if (result.IsSuccess)
            {
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

