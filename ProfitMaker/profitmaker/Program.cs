using System;

namespace profitmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            double alsat = 0.0115;
            System.Console.WriteLine("Al-Sat Farkı: {0} tl", alsat);
            System.Console.WriteLine("Hesaplamaya komisyon dahildir.");

            while (true)
            {
                try
                {
                    System.Console.WriteLine();

                    System.Console.WriteLine("/=============== ProfiMaker ===============\\");

                    Console.Write("Yatırım yapacağınız parayı giriniz: ");
                    double aPara = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Hisse fiyatını giriniz: ");
                    double halış = Convert.ToDouble(Console.ReadLine());
                    Console.Write("İstediğiniz kar miktarını giriniz giriniz: ");
                    double ikar = Convert.ToDouble(Console.ReadLine());

                    System.Console.WriteLine("/============== Hesaplanıyor ==============\\");
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    double hsatış = halış + alsat;

                    int hsayısı = (int)(aPara / hsatış);
                    Console.ForegroundColor = ConsoleColor.Green;

                    System.Console.WriteLine("Hisse sayısı: {0}", hsayısı);

                    double zsKar = ikar / hsayısı;

                    double ekar = alsat + zsKar;

                    double yüzde = ekar * 100 / halış;
                    System.Console.WriteLine("İstediğiniz kar için gerekli yükseliş: {0} lira ( %{1} )", ekar, yüzde);
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    double yHisse = halış + ekar;
                    System.Console.WriteLine("Hissenin olması gereken değeri: {0}", yHisse);
                    System.Console.WriteLine();
                    System.Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                catch { }
            }
        }

    }
}
