using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)]//Add test data <-------
        [InlineData(1, 2, 4, 7)]
        [InlineData(3, 4, 5, 12)]
        [InlineData(4, 5, 13, 22)]
        [InlineData(0, 6, 6, 12)]
        [InlineData(0, 0 , 0, 0)]
        [InlineData(-5, -3, 5, -3)]
        [InlineData(-1, -1, -1, -3)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator challenger = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                int actual = challenger.Add(num1, num2, num3);
            //Assert
                Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(20, 10, 10)]//Add test data <-------
        [InlineData(200, 100, 100)]
        [InlineData(1,1,0)]
        [InlineData(30,45,-15)]
        [InlineData(0, -6, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(-6, -6, 0)]
       
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challanger = new Calculator();
            //Act
            double actual = challanger.Subtract(minuend, subtrhend);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1,2,2)]//Add test data <-------
        [InlineData(2,3,6)]
        [InlineData(0,0,0)]
        [InlineData(0,1,0)]
        [InlineData(-1,2,-2)]

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challeger = new Calculator();
            //Act
            int actual = challeger.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10,2,5)]//Add test data <-------
        [InlineData(20, 2, 10)]
        [InlineData(1, 1, 1)]
        [InlineData(8, 2, 4)]
        [InlineData(4, 2, 2)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();
            //Act
            int actual = challenger.Divide(num1, num2);
            //Assert
            Assert.Equal(-expected, actual);
        }

    }
}
