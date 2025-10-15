using Moq;

namespace BUSINESSREQUIREMENTS.TEST
{
    public class EmployeeTests
    {
        public delegate bool IsUnder60(Employee employee);

        [Fact]
        public void Age_EmployeeObject_IsUnder60()
        {
            // arrange

            var employee = Employee.Create(1, "Ayman", 22);

            // act

            var result = employee.Age < 60;

            var expected = true;

            // assert

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Age_EmployeeIsNull_ReturnException()
        {
            // arrange

            Employee employee = null;

            // act

            IsUnder60 under60 = Employee.IsUnder60;

            // assert

            Assert.Throws<ArgumentNullException>(() => under60(employee));
        }

        [Fact]
        public void Add_TwoNumbers_ReturnSum()
        {
            // arrange

            int a = 5,
                b = 10;

            var moq = new Mock<ICalculator>();

            moq.Setup(x => x.Add(a, b)).Returns(a + b);

            // act

            var result = moq.Object.Add(a, b);

            int expected = 15;

            // assert

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 2, 4)]
        [InlineData(1, 3, 4)]
        public void Add_ThreeNumbers_ReturnSum(int a, int b, int expected)
        {
            // act

            var result = a + b;

            // assert

            Assert.Equal(expected, result);
        }
    }
}
