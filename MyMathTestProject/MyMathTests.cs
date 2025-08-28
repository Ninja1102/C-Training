using MyMathLibrary;

namespace MyMathTestProject
{
    public class MyMathTests
    {
        [Fact]
        public void AdditionOf5ElementsShouldBeCorrect()
        {
            //AAA
            //Arrange
            int expected = 15;
            int actual = 0;
            //Act
            actual = MyMath.Add(1, 2, 3, 4, 5);

            //Assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void SubtractionOf5ElementsShouldBeCorrect()
        {
            //AAA
            //Arrange
            int expected = 1;
            int actual = 0;
            //Act
            actual = MyMath.SubtractNew(3, 2);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}