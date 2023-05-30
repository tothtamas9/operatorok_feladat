using System.Threading.Channels;

namespace operatorok_feladat
{
    internal class Program
    {
        static List<string> adatok;
        static List<string> maradekos;
        static void Main(string[] args)
        {
            // 1. feladat
            adatok = File.ReadAllLines("kifejezesek.txt").ToList();
            // mindenAdat.ForEach(x => Console.WriteLine(x));

            // 2. feladat
            Console.WriteLine($"2. feladat: Kifejezések száma: {adatok.Count()}");

            // 3.feladat
            maradekos = adatok.Where(x => x.Contains("mod")).ToList();
            //maradekos.ForEach(x => Console.WriteLine(x));
            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {maradekos.Count()}");

            // 4.feladat


        }
    }
}