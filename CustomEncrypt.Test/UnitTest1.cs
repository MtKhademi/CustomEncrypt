using FluentAssertions;

namespace CustomEncrypt.Test
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(int.MaxValue, 2, 3)]
        public void Test_Add(int x, int y, int expect)
        {

            //-- Arrange
            var cl = new Calcu();

            //-- Act
            var result = cl.Add(x, y);

            //-- Assertion
            result.Should().Be(expect);
        }

    }
}