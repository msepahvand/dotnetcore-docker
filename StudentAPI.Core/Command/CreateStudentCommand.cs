using StudentAPI.Core.Models;
using MediatR;
using StudentAPI.Core.Dto;

namespace StudentAPI.Core.Command
{
    public class CreateStudentCommand : IRequest<CommandResult>
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
    }
}