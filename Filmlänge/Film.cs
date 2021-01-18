using System;
using System.Collections.Generic;
using System.Text;

namespace Filmlänge
{
    class Film
    {
        private int Minuten;
        private int Sekunden;
        private int Audiospur;
        private int Videospur;
        public int ergebnis;
        private int gesamtspur;

        public Film()
        {
            this.Minuten = 0;
            this.Sekunden = 0;
            this.Audiospur = 0;
            this.Videospur = 0;
            ergebnis = 0;
            gesamtspur = 0;
        }
        public void setAudiospur(int audiospur, int videospur)
        {
            this.Audiospur = audiospur;
            this.Videospur = videospur;
            
        }
        public void setgesamtzahl(int minuten, int sekunden)
        {
           // this.gesamtSpur = Gesamtspur;
              gesamtspur= Audiospur+Videospur;
            this.Minuten = minuten;
            this.Sekunden = sekunden;
            ergebnis = (Minuten * 60 + Sekunden)*gesamtspur;
            ergebnis = ergebnis / 8;
            ergebnis = ergebnis / 1024;
            ergebnis = ergebnis / 1024;
         
        }
        public int getgesamtzahl()
        {
            
            return ergebnis;
        }

        public static implicit operator int(Film v)
        {
            throw new NotImplementedException();
        }
    }


    
}
