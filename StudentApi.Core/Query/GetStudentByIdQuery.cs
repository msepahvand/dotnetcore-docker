using MediatR;
using StudentApi.Core.Dto;

namespace StudentApi.Core.Query
{
    public class GetStudentByIdQuery : IRequest<StudentDto>
    {
        public int Id { get; set; }
    }
}
