using System;
using System.Linq;

namespace HataFırlatma
{
    class Program
    {
        static void check_pass(string password)
        {
            if(password.Length<8 || password.Length>15)
                throw new Exception("Parola 7-15 karakter arasında olmalıdır!");
            if(!password.Any(char.IsDigit))
                throw new Exception("Parola en az bir rakam içermelidir");
            if(!password.Any(char.IsLetter))
                throw new Exception("Parola en az bir harf içermelidir");
        }

        static void Main(string[] args)
        {
            int sayac = 0;
            do
            {
                Console.Write("Parolanızı giriniz: ");
                string parola = Console.ReadLine();
                try{
                    check_pass(parola);
                    Console.WriteLine("Parola geçerli");
                    sayac += 1;
                }
                catch(Exception ex){
                    Console.WriteLine(ex.Message);
                    sayac = 0;
                }
            } while (sayac==0);
        }
    }
}
