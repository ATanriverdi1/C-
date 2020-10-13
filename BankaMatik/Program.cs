using System;

namespace BankaMatik
{
    class Program
    {
        static void Main(string[] args)
        {
            string secim = "";
            double bakiye = 0;
            double ekhesap = 1000;
            double ekhesaplimit = 1000;

            do
            {
                Console.Write("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çek\n4-Çıkış\nSeçim: ");
                secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Bakiyeniz {0} TL", bakiye);
                        Console.WriteLine("Ek Hesabınız {0} TL", ekhesap);
                        break;
                    case "2":
                        Console.Write("Yatırmak İstediğiniz Miktar: ");
                        double yatirilan = double.Parse(Console.ReadLine());
                        
                        if(ekhesap<ekhesaplimit){
                            
                            double ekkullanilan = ekhesaplimit - ekhesap ;
                            if(yatirilan>=ekkullanilan){
                                ekhesap = ekhesaplimit;
                                bakiye = yatirilan - ekkullanilan;
                            }
                            else
                                ekhesap += yatirilan;
                        }
                        else
                            bakiye += yatirilan;
                        break;
                    case "3":
                        Console.Write("Çekmek İstediğiniz Miktar: ");
                        double cekilen = double.Parse(Console.ReadLine());
                        if(cekilen>bakiye){
                            double toplam = (bakiye + ekhesap);

                            if(toplam>=cekilen){
                                Console.Write("Ek Hesap Kullanılsın Mı? (e/h):");
                                string tercih = Console.ReadLine();

                                if(tercih == "e"){
                                    Console.WriteLine("Paranızı Alabilirsiniz");
                                    ekhesap -= (cekilen-bakiye);
                                    bakiye = 0;
                                }
                                else
                                    Console.WriteLine("Yetersiz Bakiye!");
                            }
                            else
                                Console.WriteLine("Yetersiz Bakiye!");
                        } 
                        else{
                            Console.WriteLine("Paranızı Alabilirsiniz");
                            bakiye -= cekilen;
                        }  
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;
                }
            } while (secim != "4");
        }
    }
}
