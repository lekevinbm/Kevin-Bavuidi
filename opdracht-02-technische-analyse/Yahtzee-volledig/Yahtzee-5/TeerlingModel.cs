using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    class TeerlingModel
    {
        // Members die de waarde van de teerling onthouden
        private bool isVast;
        private int aantalOgen;

        private static Random randomNummer;

        public TeerlingModel()
        {
            // Zet elke teerling standaard niet vast
            isVast = false;

            // Standaard waarde is 1
            aantalOgen = 1;

            // Maak een instantie van de random generator
            if (randomNummer == null)
            {
                randomNummer = new Random();
            }

            
        }

        /*
            Methode die een willekeurig getal berekent voor de teerling
        */
        public void Werp()
        {
            aantalOgen = randomNummer.Next(1, 7);
        }

        /*
            Getter voor het aantal ogen (= waarde van de teerling)
        */
        public int AantalOgen
        {
            get
            {
                return aantalOgen;
            }
            set
            {
              aantalOgen = value;
            }
        }

        /*
            Draai de isVast waarde om
        */
        public void toggleVast()
        {
            isVast = !isVast;
        }

        

        /*
            Getter voor de isVast waarde
        */
        public bool Vast
        {
            get
            {
                return isVast;
            }
        }

    }
}
