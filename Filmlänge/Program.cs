using System;

namespace Filmlänge
{
    class Program
    {
        static void Main(string[] args)
        {
            Film Informationgesamt = new Film();
            Informationgesamt.setBitrate(384, 8000);
            Informationgesamt.setZeit(90, 30);
           float result =  Informationgesamt.getgesamtzahl();
            
            Console.WriteLine("Gib: " + result);
            Console.ReadLine();
           


        }
    }
}
