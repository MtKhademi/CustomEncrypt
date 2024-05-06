using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEncrypt.Test
{
    public class EncryptorTest
    {

        [Theory]
        [InlineData(5, "10XXXX5****9")]
        //LengthNumber....First....Second....Third.......>
        //125=>  3....1....2....5   => 3!@ed1#$RF...
        public void When_call_encrypt_metod_Expect_currect_string_result(int number, string encrypt)
        {

            var en = new Encryptor();

            string result = en.Encrypt(number);

            //result[0].Should().Be('1');
            //result[5].Should().Be('5');
            //result[-1].Should().Be('5');
            result.Length.Should().BeLessThanOrEqualTo(20);
        }


        [Theory]
        [InlineData("10XXXX5****9", 5)]
        [InlineData("10XXXX5&&&&3&&&&4XXXX7", 534)]
        [InlineData("10)&@)1)^Q#9)#Q(8", 19)]
        // LengthNumber....First....Second....Third.......>
        //125=>  3....1....2....5   => 3!@ed1#$RF...
        public void When_call_dEncrypt_metod_Expect_currect_string_result(string encrypt, int number)
        {

            var en = new Encryptor();

            int result = en.Dencrypt(encrypt);

            result.Should().Be(number);
        }
    }
}
