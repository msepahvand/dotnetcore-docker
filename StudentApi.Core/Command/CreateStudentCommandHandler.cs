using System.Threading.Tasks;
using StudentApi.Core.Models;
using MediatR;

namespace StudentApi.Core.Command
{
    public class CreateStudentCommandHandler : IAsyncRequestHandler<CreateStudentCommand, CommandResult>
    {
        private readonly DataContext _dataContext;

        public CreateStudentCommandHandler(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<CommandResult> Handle(CreateStudentCommand command)
        {
            if (string.IsNullOrEmpty(command?.FamilyName) || string.IsNullOrEmpty(command.GivenName))
            {
                return new CommandResult(false);
            }
            _dataContext.Students.Add(new Student(){
                GivenName = command.GivenName,
                FamilyName = command.FamilyName
            });

            bool isSuccess = await _dataContext.SaveChangesAsync() > 0;

            return new CommandResult(isSuccess);
        }
    }
}