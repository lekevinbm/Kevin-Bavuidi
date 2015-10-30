using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
    public class GameController
    {
        private GameView view;
        private TrapdoorController trapdoorcont;

        private MoneydropController moneyDropcontr;

        public GameController()
        {
            view = new GameView(this);

            moneyDropcontr = new MoneydropController(this);

            //moneyDrop.AantalTrapdoors = 4;
            moneyDropcontr.initialize();

        }

    

    
        public MoneydropView getViewMoneydrop()
        {
            return moneyDropcontr.getView();
        }
        

        public GameView getView()
        {
            return view;
        }
    }
}
