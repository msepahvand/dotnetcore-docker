using MediatR;
using StudentAPI.Core.Dto;

namespace StudentAPI.Core.Query
{
    public class GetStudentByIdQuery : IRequest<StudentDto>
    {
        public int Id { get; set; }
    }
}
