using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_5
{
    public class YahtzeeController
    {
        private GameController container;

        private YahtzeeView view;
        private YahtzeeModel model;

        public YahtzeeController(GameController cont)
        {
            container = cont;
            view = new YahtzeeView(this);
            model = new YahtzeeModel();
        }

        // Extra methode die dient als factory en alle methodes opsomt die uitgevoerd moeten worden
        // nadat de configuratie gebeurd is
        // Zou in de constructor kunnen, maar dan heb je niet meer de kans op bepaalde configuratievariabelen (aantal teerlingen, ...) aan te passen voor het spel wordt opgebouwd
        public void initialize()
        {
            maakTeerlingen();
        }

        // Voeg aantal teerlingen toe aan het model
        private void maakTeerlingen()
        {
            // Loop over het aantal teerlingen dat er mogen zijn (gedefiniëerd in GameController)
            for (int teerlingNummer = 0; teerlingNummer < AantalTeerlingen; ++teerlingNummer)
            {
                // Maak een nieuwe teerling aan
                TeerlingController teerling = new TeerlingController();

                // Voeg de teerling toe aan het model
                model.addTeerling(teerling);
            }
        }

        /*
            Haal de views op van alle teerlingen
        */
        public List<TeerlingView> getTeerlingenView()
        {
            // Maak een lijst die de views zal opvangen
            List<TeerlingView> teerlingenView = new List<TeerlingView>();

            // Loop over het huidig aantal teerlingen uit het model
            foreach (TeerlingController teerling in model.Teerlingen)
            {
                // Haal de view op voor iedere teerling
                TeerlingView teerlingView = teerling.getView();

                // Voeg de teerling toe aan de lijst die de views opvangt
                teerlingenView.Add(teerlingView);
            }

            // Return de lijst met teerlingViews
            return teerlingenView;
        }

        /*
           Return de volledige Yahtzee view
        */
        public YahtzeeView getView()
        {
            return view;
        }

        /*
            Methode die uitgevoerd wordt van zodra er op de "smijt alle teerlingen" 
            knop wordt gedrukt
        */
        public void smijtAlleTeerlingen()
        {

          // Haal de teerlingen op uit het model
          List<TeerlingController> teerlingen = model.Teerlingen;
            
          // Controleer of het maximum aantal worpen niet is bereikt
            if (model.aantalWorpen < MaximumAantalWorpen)
            {
                
                 // Loop over de teerlingen
                foreach (TeerlingController teerling in teerlingen)
                {
                    // Voer de werp methode uit op elke teerling
                    teerling.Werp();

                }

                // Tel eentje bij het huidig aantal worpen
                model.voegWorpToe();
            }

            if (model.aantalWorpen == MaximumAantalWorpen)
            {
              foreach (TeerlingController teerling in teerlingen)
              {
                SomAantalOgen += teerling.AantalOgen;
                view.EindeUpdate();
              }
              
            }

            // Breng de container op de hoogte dat er veranderingen hebben plaatsgevonden
            container.modelHasChanged();
            
            
        }

        public void resetWorpen()
        {
          HuidigAantalWorpen = 0;
          SomAantalOgen = 0;

          // Haal de teerlingen op uit het model
          List<TeerlingController> teerlingen = model.Teerlingen;

          foreach (TeerlingController teerling in model.Teerlingen)
          {
            teerling.toggleVast();
            teerling.AantalOgen = 1;
          }

          container.modelHasChanged();
        }

        /*
            getter en setter voor het maximum aantal worpen
        */
        public int MaximumAantalWorpen
        {   
            get
            {
                return model.MaximumAantalWorpen;
            }
            set
            {
                model.MaximumAantalWorpen = value;
            }
            
        }

        /*
            getter voor het huidig aantal worpen
        */
        public int HuidigAantalWorpen
        {
            get
            {
                return model.aantalWorpen;
            }
          set
          {
            model.aantalWorpen = value;
          }
        }

        /*
            getter en setter voor het vastgesteld aantal teerlingen
        */
        public int AantalTeerlingen
        {
            get
            {
                return model.AantalTeerlingen;
            }
            set
            {
                model.AantalTeerlingen = value;
            }
        }

        public int SomAantalOgen
        {
          get
          {
            return model.SomAantalOgen;
          }
          set
          {
            model.SomAantalOgen = value;
          }
        }
    }
}
