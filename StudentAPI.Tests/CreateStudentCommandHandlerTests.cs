using Microsoft.EntityFrameworkCore;
using Moq;
using StudentAPI.Core.Command;
using StudentAPI.Core.Models;
using Xunit;

namespace StudentAPI.Tests
{
    public class CreateStudentCommandHandlerTests
    {
        private readonly CreateStudentCommandHandler _sut;

        public CreateStudentCommandHandlerTests()
        {
            var mockSet = new Mock<DbSet<Student>>();
            var mockContext = new Mock<DataContext>();
            mockContext.Setup(m => m.Students).Returns(mockSet.Object);
            _sut = new CreateStudentCommandHandler(mockContext.Object);
        }

        [Fact]
        public void Create_Student_Should_Return_False_When_Params_Are_Empty()
        {
            var result = _sut.Handle(new CreateStudentCommand()).Result;
            Assert.NotNull(result);
            Assert.Equal(false, result.IsSuccess);
        }
    }
}
