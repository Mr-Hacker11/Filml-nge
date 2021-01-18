using System;

namespace Filmlänge
{
    class Program
    {
        static void Main(string[] args)
        {
            Film Spur = new Film();
            Spur.setAudiospur(384, 8000);
            Film Zeit= new Film();
            Zeit.setgesamtzahl(90, 30);
            Zeit.getgesamtzahl();
            string Ausgabe = Zeit.ToString();
            Console.WriteLine(Ausgabe+"Gib");
           


        }
    }
}
