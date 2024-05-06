using CustomEncrypt;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var enc = new Encryptor();
            for (int i = 0; i < 100; i++)
            {
                var number = random.Next(10, 100);
                var strEnc = enc.Encrypt(number);
                Console.WriteLine($"{number} :::=> {strEnc} <<===::: DEC : {enc.Dencrypt(strEnc)}");
            }
        }
    }
}
