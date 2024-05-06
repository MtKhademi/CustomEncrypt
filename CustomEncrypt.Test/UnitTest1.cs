using FluentAssertions;

namespace CustomEncrypt.Test
{
    public class UnitTest1
    {

        [Fact]
        public void NAME() 
        {

            //-- Arrange
            var cl = new Calcu();

            //-- Act
            var result = cl.Add(1, 2);

            //-- Assertion
            result.Should().Be(2);
        }

    }
}