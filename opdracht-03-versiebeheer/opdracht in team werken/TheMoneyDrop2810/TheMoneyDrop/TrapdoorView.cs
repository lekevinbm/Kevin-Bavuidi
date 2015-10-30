using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace TheMoneyDrop
{
  public partial class TrapdoorView : UserControl
  {
        
       

        private TrapdoorController _controller;
    
    
    public TrapdoorView(TrapdoorController controller)
    {
     

      _controller = controller;
            InitializeComponent();
        }

    private void label1_Click(object sender, EventArgs e)
    {
            _controller.model.Inzet = Convert.ToSingle(txtInzet.Text);
        }

    private void txtInzet_TextChanged(object sender, EventArgs e)
    {
         
        
    }

    public void UpdateUI()
    {
           
            lblIngezet.Text = _controller.model.Inzet.ToString();
            txtInzet.Text = "";
            
    }

    public void UpdateUIAfterDrop()
    {
      if (_controller.model.MagHijVallen)
      {
        if (_controller.model.ValtHij)
        {
          lblIngezet.BackColor = Color.DarkRed;
        }
      }
    }

    public void resetUI()
    {
      lblIngezet.BackColor = DefaultBackColor;
      lblIngezet.Text = _controller.model.Inzet.ToString();
      
    }

        public void updateTrapdoorButton(bool value)
        {
            btnInzetten.Enabled = value;
        }

    private void TrapdoorView_Load(object sender, EventArgs e)
        {

        }

     private void btnInzetten_Click(object sender, EventArgs e)
        {
           
            float inzet;
          

          if (float.TryParse(txtInzet.Text, out inzet))
          {
            _controller.model.Inzet = inzet; 
          }
          else
          {
            _controller.model.Inzet = 0;
          } 
            UpdateUI();

        }

        private void lblIngezet_Click(object sender, EventArgs e)
        {

        }
    }
}
