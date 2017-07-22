using System.Collections.Generic;
using MediatR;
using StudentApi.Core.Dto;

namespace StudentApi.Core.Query
{
    public class GetAllStudentsQuery : IRequest<IList<StudentDto>>
    {
    }
}