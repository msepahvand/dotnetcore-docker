using System.Threading.Tasks;
using StudentAPI.Core.Models;
using MediatR;
using StudentAPI.Core.Dto;

namespace StudentAPI.Core.Query
{
    public class GetStudentByIdQueryHandler : IAsyncRequestHandler<GetStudentByIdQuery, StudentDto>
    {
        private readonly DataContext _dbContext;

        public GetStudentByIdQueryHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<StudentDto> Handle(GetStudentByIdQuery message)
        {
            if (message?.Id > 0)
            {
                var student = await _dbContext.Students.FindAsync(message.Id);
                return new StudentDto()
                {
                    GivenName = student.GivenName,
                    FamilyName = student.FamilyName,
                    Id = student.Id
                };
            }
            return null;
        }
    }
}
