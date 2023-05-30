using System.Threading.Channels;

namespace operatorok_feladat
{
    internal class Program
    {
        static List<string> muveletek;
        static void Main(string[] args)
        {
            // 1. feladat
            muveletek = File.ReadAllLines("kifejezesek.txt").ToList();
            // mindenAdat.ForEach(x => Console.WriteLine(x));

            // 2. feladat
            Console.WriteLine($"2. feladat: Kifejezések száma: {muveletek.Count()}");

            // 3.feladat
            int darab = muveletek.Count(x => x.Contains("mod"));
            //maradekos.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {darab}");

            // 4.feladat
            bool vanIlyen = false;

            foreach (var sor in muveletek)
            {
                var tomb = sor.Split();
                if (Convert.ToInt32(tomb[0])%10==0 && Convert.ToInt32(tomb[2]) % 10 == 0)
                {
                    vanIlyen = true;
                    break;
                }
            }
            if (vanIlyen)
            {
                Console.WriteLine("van");
            }
            else
            {
                Console.WriteLine("nincs");
            }

        }
    }
}