using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
    public class MoneydropController
    {
        private GameController controller;

        private MoneydropModel model;
        private MoneydropView view;

        private Random randomNummer;

        public MoneydropController(GameController co)
        {
            controller = co;
            view = new MoneydropView(this);
            model = new MoneydropModel();
        }
        
        public void initialize()
        {
            
                maakTrapdoors(AantalTrapdoors);
            
        }

        private void maakTrapdoors(int AantalTrapdoors)
        {
            if (HuidigAantalRondes < MaximumAantalRondes)
            {
                for (int trapdoorNummer = 0; trapdoorNummer < AantalTrapdoors; ++trapdoorNummer)
                {
                    TrapdoorController trapdoor = new TrapdoorController();
                    model.addTrapdoor(trapdoor);
                }
            }
        }
        public List<TrapdoorView> getTrapdoorsView()
        {
            List<TrapdoorView> trapdoorsView = new List<TrapdoorView>();

            foreach (TrapdoorController trapdoor in model.Trapdoors)
            {
                TrapdoorView trapdoorView = trapdoor.getView();
                trapdoorsView.Add(trapdoorView);
            }

            return trapdoorsView;
        }

        public MoneydropView getView()
        {
            return view;
        }

        public void moneyDrop()
        {
            if (HuidigAantalRondes < MaximumAantalRondes)
            {
                List<TrapdoorController> trapdoors = model.Trapdoors;
                model.SomLabels = 0;
                foreach (TrapdoorController trapdoor2 in trapdoors)
                {
                    model.SomLabels += trapdoor2.model.Inzet;
                }               

                if (model.SomLabels == MogelijkeWinst)
                {
                    int randomTrapdoor = kiesTrapdoor();
                    trapdoors[randomTrapdoor].model.ValtHij = false;
                    model.MogelijkeWinst = trapdoors[randomTrapdoor].model.Inzet;
                    foreach (TrapdoorController trapdoor in trapdoors)
                    {
                        trapdoor.model.MagHijVallen = true;

                        if (trapdoor.model.ValtHij == true)
                        {
                            trapdoor.Drop();
                 
                        }
                    }
                    
                    view.resetStatusLabel();
                    toggleButton(false);

                    if (trapdoors[randomTrapdoor].model.Inzet == 0)
                    {
                      HuidigAantalRondes = 4;
                       
                    }

                    
                    

                }

                else {
                    view.errorUI();
                    model.SomLabels = 0;
                }



            }
            
        }

        public void toggleButton(bool value)
        {
            if (HuidigAantalRondes < MaximumAantalRondes)
            {
                List<TrapdoorController> trapdoors = model.Trapdoors;
                foreach (TrapdoorController trapdoor in trapdoors)
                {
                    trapdoor.toggleEnabled(value);
                }

            }
        }

        public void trapdoorReset()
        {
          if (HuidigAantalRondes < MaximumAantalRondes)
          {
            List<TrapdoorController> trapdoors = model.Trapdoors;
            foreach (TrapdoorController trapdoor in trapdoors)
            {
              trapdoor.trapdoorReset();
            }

          }
        }
       
        


        public void berekenAlles()
        {
            if (UwInzet <= Krediet && UwInzet > 0)
            {
                switch (AantalTrapdoors)
                {
                    case 4:
                        MogelijkeWinst = UwInzet * 100;
                        break;
                    default:
                        MogelijkeWinst = UwInzet * 100;
                        break;
                }

                Krediet = Krediet - UwInzet;
                view.resetStatusLabel();
                voegRondeToe();
                view.UpdateUI();

            }

            else
            {
                view.errorUI();
            }
        }

        
        public int kiesTrapdoor()
        {
          randomNummer = new Random();
          return randomNummer.Next(1, 4);

        }

        public void voegRondeToe()
        {
            HuidigAantalRondes++;
            if (HuidigAantalRondes == 5)
            {
              HuidigAantalRondes = 0;
            }

            
            view.UpdateUI();
        }

        public void nieuweLevel()
        {
          Krediet += MogelijkeWinst;
        }

        public int MaximumAantalRondes
        {
            get
            {
                return model.MaximumAantalRondes;
            }
            set
            {
                model.MaximumAantalRondes = value;
            }

        }

        public int HuidigAantalRondes
        {
            get
            {
                return model.HuidigAantalRondes;
            }
            set
            {
                model.HuidigAantalRondes = value;
            }
        }

        public int AantalTrapdoors
        {
            get
            {
                return model.AantalTrapdoors;
            }
            set
            {
                model.AantalTrapdoors = value;
            }
        }

        public float Krediet
        {
          get { return model.Krediet; }
          set { model.Krediet = value; }

        }

        public float UwInzet
        {
          get { return model.UwInzet; }
          set { model.UwInzet = value; }
        }  

        public float MogelijkeWinst
        {
          get { return model.MogelijkeWinst; }
          set { model.MogelijkeWinst = value; }
        }

    }
}



















