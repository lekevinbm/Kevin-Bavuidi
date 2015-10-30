﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class TeerlingController
    {
        // Members die de model en de view van de teerlingen zullen onthouden
        private TeerlingModel model;
        private TeerlingView view;

        // Constructor
        public TeerlingController()
        {
            // Maak instanties van model en view aan
            model = new TeerlingModel();

            /* 
                Injecteer huidige instante (=controller) zodat de view kan communiceren
                wanneer er een bepaald event heeft plaatsgevonden
            */
            view = new TeerlingView(this);
        }

        /*
            Return de view van de teerling
        */
        public TeerlingView getView()
        {
            return view;
        }

        /*
            Methode die opvangt wanneer er op een individuele teerling "smijt" knop wordt gedrukt
        */
        public void Werp()
        {
            // Controleer of de teerling niet is vastgezet
            if (!model.Vast)
            {
                // Voer de random generator methode in het model uit
                model.Werp();

                // Update de view met de nieuwe waarde die de teerling heeft gekregen
                view.updateUI();
            }
        }

        // Draai de 'isVast' waarde om wanneer er op de teerling wordt geklikt
        public void toggleVast()
        {
            // Zeg tegen het model dat de teerling isVast waarde moet omgedraaid worden
            model.toggleVast();

            // Update de view met de nieuwe waarde die de teerling heeft gekregen
            view.updateUI();
        }

       
        /*
            Return de waarde die onthoudt of de teerling vast staat of niet
        */
        public bool Vast
        {
            get
            {
                return model.Vast;
            }
        }

        /*
           Return de waarde met de waarde van de teerling (= aantal ogen)
       */
        public int AantalOgen
        {
            get
            {
                return model.AantalOgen;
            }
            set
            {
                model.AantalOgen = value;
            }
        }

       
    }
}
