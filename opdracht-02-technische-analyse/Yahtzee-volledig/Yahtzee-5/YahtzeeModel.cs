using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    class YahtzeeModel
    {
        // List die alle teerlingen zal bewaren
        private List<TeerlingController> teerlingen = new List<TeerlingController>();

        /*
            De members die de configuratie voor het Yahtzeespel zullen onthouden
        */
        private int aantalTeerlingen = 0;
        private int huidigAantalWorpen = 0;
        private int maximumAantalWorpen = 0;
        private int somAantalOgen = 0;
        

        /*
            Voeg een teerling toe aan de lijst met teerlingen
        */
        internal void addTeerling(TeerlingController teerling)
        {
            teerlingen.Add(teerling);
        }

        /*
            Getter voor de lijst met eerlingen
        */
        public List<TeerlingController> Teerlingen
        {
            get
            {
                return teerlingen;
            }
        }

        /*
            getter voor het aantal worpen
        */
        public int aantalWorpen
        {
            get
            {
                return huidigAantalWorpen;
            }
          set
          {
            huidigAantalWorpen = value;
          }
        }

        /*
            getter en setter voor het maximum aantal worpen
        */
        public int MaximumAantalWorpen
        {
            get
            {
                return maximumAantalWorpen;
            }
            set
            {
                maximumAantalWorpen = value;
            }
        }

        /*
            getter en setter voor het aantal teerlingen
        */
        public int AantalTeerlingen
        {
            get
            {
                return aantalTeerlingen;
            }
            set
            {
                aantalTeerlingen = value;
            }
        }

        /*
            tel eentje bij het huidig aantal worpen
        */
        public int voegWorpToe()
        {
            return ++huidigAantalWorpen;
        }

       /*
            getter en setter voor de som van de aantal ogen
        */
        public int SomAantalOgen
        {
            get
            {
                return somAantalOgen;
            }
            set
            {
                somAantalOgen = value;
            }
        }

    }
}
