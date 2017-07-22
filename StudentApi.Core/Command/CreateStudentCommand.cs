using StudentApi.Core.Models;
using MediatR;
using StudentApi.Core.Dto;

namespace StudentApi.Core.Command
{
    public class CreateStudentCommand : IRequest<CommandResult>
    {
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
    }
}