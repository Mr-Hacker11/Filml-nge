using System;
using System.Collections.Generic;
using System.Text;

namespace Filmlänge
{
    class Film
    {
        private float Sekunden;
        public float ergebnis;
        private float bitrate;
        private float zeit;

        public Film()
        {
            this.Sekunden = 0;
            bitrate = 0;
            ergebnis = 0;
            zeit = 0;
          
        }
        public void setBitrate(float audiospur, float videospur)
        {
            
            this.bitrate = videospur;
            videospur = audiospur + videospur;
     
            
        }
        public void setZeit(float minuten, float sekunden)
        {
            
            this.Sekunden =zeit;
            zeit = (minuten * 60 + sekunden);


        }
        public float getgesamtzahl()
        {
        
           float kib = Sekunden * bitrate;
            float kb = kib / 8;
            float mib = kb / 1024;
            float gib = mib / 1024;
            return gib;
            
             

            
        }

    }


    
}
