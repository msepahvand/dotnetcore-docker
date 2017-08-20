using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using StudentAPI.Core.Dto;
using StudentAPI.Core.Models;

namespace StudentAPI.Core.Query
{
    public class GetAllStudentsQueryHandler : IAsyncRequestHandler<GetAllStudentsQuery, IList<StudentDto>>
    {
        private readonly DataContext _dbContext;

        public GetAllStudentsQueryHandler(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IList<StudentDto>> Handle(GetAllStudentsQuery message)
        {
            var students = await _dbContext.Students.ToListAsync();

            return students.Select(student => new StudentDto{
                GivenName = student.GivenName,
                FamilyName = student.FamilyName,
                Id = student.Id
            }).ToList();
        }
    }
}