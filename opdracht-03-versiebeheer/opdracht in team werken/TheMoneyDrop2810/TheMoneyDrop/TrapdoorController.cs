using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
  public class TrapdoorController
  {
        private TrapdoorView view;
        public TrapdoorModel model;
        

        public TrapdoorController()
        {
            view = new TrapdoorView(this);

            model = new TrapdoorModel();
        }
        public void Drop()
        {
                view.UpdateUIAfterDrop();
        }

        public void toggleEnabled(bool value)
        {
            view.updateTrapdoorButton(value);
        }

        public void trapdoorReset()
        {
          model.Inzet = 0;
          model.ValtHij = true;
          view.resetUI();
        }

        public TrapdoorView getView()
        {
            return view;
        }



    }
}
