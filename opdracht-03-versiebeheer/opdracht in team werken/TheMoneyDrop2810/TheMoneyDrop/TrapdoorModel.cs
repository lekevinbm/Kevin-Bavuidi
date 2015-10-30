using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMoneyDrop
{
  public class TrapdoorModel
  {
    private float inzet;
    private bool magHijVallen = false;
    private bool valtHij = true;

    public float Inzet
    {
      get { return inzet; }
            set { inzet = value; }
    }

    public bool ValtHij
    {
      get { return valtHij; }
      set { valtHij = value; }
    }

    public bool MagHijVallen
        {
            get { return magHijVallen; }
            set { magHijVallen = value;  }
        }

  }

}
