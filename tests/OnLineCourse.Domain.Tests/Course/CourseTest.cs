using OnLineCourse.Domain;
using Xunit;

namespace OnLineCourse.Domain.Tests
{
    public class CourseTest
    {
        [Fact]
        public void Course_Should_Be_Created_With_Valid_Data()
        {
            // Arrange
            var name = "C#";
            var workload = 80;
            var targetAudience = "Students";
            var price = 950.00m;

            // Act
            var course = new Course(name, workload, targetAudience, price);

            // Assert
            Assert.Equal(name, course.Name);
            Assert.Equal(workload, course.WorkLoad);
            Assert.Equal(targetAudience, course.TargetAudience);
            Assert.Equal(price, course.Price);
        }
    }
}