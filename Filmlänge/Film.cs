using System;
using System.Collections.Generic;
using System.Text;

namespace Filmlänge
{
    class Film
    {
        private float Minuten;
        private float Sekunden;
        private float Audiospur;
        private float Videospur;
        private float gesamtergebnis;
        public float ergebnis;
        private float gesamtspur;

        public Film()
        {
            this.Minuten = 0;
            this.Sekunden = 0;
            this.Audiospur = 0;
            this.Videospur = 0;
            gesamtergebnis = 0;
            ergebnis = 0;
            gesamtspur = 0;
        }
        public void setAudiospur(float audiospur, float videospur)
        {
            this.Audiospur = audiospur;
            this.Videospur = videospur;
            
        }
        public void setgesamtzahl(float minuten, float sekunden)
        {
           // this.gesamtSpur = Gesamtspur;
              gesamtspur= Audiospur+Videospur;
            this.Minuten = minuten;
            this.Sekunden = sekunden;
            ergebnis = (Minuten * 60 + Sekunden)*gesamtspur;
        }
        public float getgesamtzahl()
        {
            return ergebnis;
        }
    }


    
}
