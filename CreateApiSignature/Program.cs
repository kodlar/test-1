using System;
using System.Security.Cryptography;
using System.Text;

namespace CreateApiSignature
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal deger = 4.61M;
            string fractionString = "##";
            var result = deger.ToString("#,0.0000");
            Console.WriteLine(result);
            Console.ReadLine();

            /*
            var key = new byte[128];
            using (var generator = RandomNumberGenerator.Create())
                generator.GetBytes(key);
            string apiKey = Convert.ToBase64String(key);


            var secret = new byte[32];
            using (var generator = RandomNumberGenerator.Create())
                generator.GetBytes(secret);
            string apiSecret = Convert.ToBase64String(secret);

            Console.WriteLine("Your: Api Key");
            Console.WriteLine(apiKey);
            Console.WriteLine("Your Api Secret");
            Console.WriteLine(apiSecret);
            Console.ReadLine();
            var yourAPIKey = "d1df213f-0cf8-4967-966d-f0bf5e1f6286";
            var unixTimeStamp = DateTime.UtcNow.Ticks;
            var yourPrivateKey = "WAmVwrKc3f4G005Ka9jADr+/KHk/SMat";
            string message = yourAPIKey + unixTimeStamp;
            using (HMACSHA256 hmac = new HMACSHA256(Convert.FromBase64String(yourPrivateKey)))
            {
                byte[] signatureBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(message));
                string XSignature = Convert.ToBase64String(signatureBytes);
                Console.WriteLine(XSignature);
                Console.ReadLine();
            }

         */
        }
    }
}
