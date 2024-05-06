using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomEncrypt
{
    public class Encryptor
    {

        private List<string> letters = ["!", "@", "#", "$", "q", "Q", "%",
            "^", "&", "*", "(", ")"];
        private string GetRandom()
        {
            var rand = new Random();
            return letters[rand.Next(0, letters.Count)];
        }

        public string Encrypt(int number)
        {
            var numberInString = number.ToString();

            var randomNumber = (new Random()).Next(1, 9);

            var result = $"{numberInString.Length + randomNumber}";

            foreach (var item in numberInString)
            {
                result +=
                    $"{GetRandom()}" +
                    $"{GetRandom()}" +
                    $"{GetRandom()}" +
                    $"{GetRandom()}{item}";
            }


            return result +
                    $"{GetRandom()}" +
                    $"{GetRandom()}" +
                    $"{GetRandom()}" +
                    $"{GetRandom()}{randomNumber}";

        }

        public int Dencrypt(string encrypt)
        {
            // 10XXXX5****9
            var numberLength = "";
            var number = "";
            foreach (var item in encrypt)
            {
                if (char.IsDigit(item))
                    numberLength += item;
                else
                    break;
            }
            var lastNumber = int.Parse(encrypt[encrypt.Length - 1].ToString());

            var xx = numberLength.Length;
            int countNumber = int.Parse(numberLength) - lastNumber; // COUNT NUMBER

            for (int i = xx + 4; i < encrypt.Length; i += 5)
            {
                number += encrypt[i];
                countNumber--;
                if (countNumber <= 0)
                    break;
            }

            return int.Parse(number);
        }
    }
}
