using System.Collections.Generic;
using MediatR;
using StudentAPI.Core.Dto;

namespace StudentAPI.Core.Query
{
    public class GetAllStudentsQuery : IRequest<IList<StudentDto>>
    {
    }
}