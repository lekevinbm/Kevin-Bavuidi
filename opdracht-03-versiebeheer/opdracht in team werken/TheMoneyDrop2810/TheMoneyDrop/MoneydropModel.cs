using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
    class MoneydropModel
    {
        private List<TrapdoorController> trapdoors = new List<TrapdoorController>();

        private int aantalTrapdoors = 4;
        private int huidigAantalRondes = 0;
        private int maximumAantalRondes = 5;
        private float krediet = 500;
        private float uwInzet;
        private float mogelijkeWinst;
        private float somLabels;


        internal void addTrapdoor(TrapdoorController trapdoor)
        {
            trapdoors.Add(trapdoor);
        }

        public List<TrapdoorController> Trapdoors
        {
            get
            {
                return trapdoors;
            }
        }

        
        public int MaximumAantalRondes
        {
            get
            {
                return maximumAantalRondes;
            }
            set
            {
                maximumAantalRondes = value;
            }
        }

        public float SomLabels
        {
            get
            {
                return somLabels;
            }
            set
            {
                somLabels = value;
            }
        }

        public int AantalTrapdoors
        {
            get
            {
                return aantalTrapdoors;
            }
            set
            {
                aantalTrapdoors = value;
            }
        }

        public float Krediet
        {
          get { return krediet; }
          set { krediet = value; }

        }

        public float UwInzet
        {
          get { return uwInzet; }
          set { uwInzet = value; }
        }  
      
      public float MogelijkeWinst
        {
          get { return mogelijkeWinst; }
          set { mogelijkeWinst = value; }
        }

        public int HuidigAantalRondes
        {
            get { return huidigAantalRondes; }
            set { huidigAantalRondes = value; }
        }

        
    }
}

