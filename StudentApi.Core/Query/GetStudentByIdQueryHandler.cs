using System.Threading.Tasks;
using StudentApi.Core.Models;
using MediatR;
using StudentApi.Core.Dto;

namespace StudentApi.Core.Query
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
