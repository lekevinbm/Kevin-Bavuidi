using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMoneyDrop
{
    public partial class MoneydropView : UserControl
    {
        private MoneydropController controller;

        public MoneydropView(MoneydropController moneydropController)
        {
            controller = moneydropController;
            InitializeComponent();
        }

        private void MoneydropView_Load(object sender, EventArgs e)
        {
            List<TrapdoorView> trapdoors = controller.getTrapdoorsView();

            int trapdoorWidth = trapdoors.First().Width;
            int trapdoorHeight = trapdoors.First().Height;

            foreach (TrapdoorView trapdoor in trapdoors)
            {
                TrapdoorView huidigeTrapdoor = trapdoor;
                int xPos = trapdoors.IndexOf(trapdoor) * trapdoorWidth;

                huidigeTrapdoor.Location = new Point(xPos, 0);

                Controls.Add(huidigeTrapdoor);
                
            }

            grpBox.Location = new Point(3, 153);
           
        }


        public void UpdateUI()
        {
            switch (controller.HuidigAantalRondes)
            {
                case 0:
                  lblRonde1.ForeColor = Color.Black;
                  lblRonde2.ForeColor = Color.Black;
                  lblRonde3.ForeColor = Color.Black;
                  lblRonde4.ForeColor = Color.Black;
                  controller.toggleButton(false);
                  lblTeWinnen.Text = "0";
                  controller.trapdoorReset();
                  btnInzet.Enabled = true;
                  controller.nieuweLevel();
                
                  break;
                case 1:
                    lblRonde1.ForeColor = Color.Green;
                    btnVallen.Enabled = true;
                    controller.toggleButton(true);
                    btnInzet.Enabled = false;
                    lblTeWinnen.Text = controller.MogelijkeWinst.ToString();
                    break;
                case 2:
                    lblRonde2.ForeColor = Color.Green;
                    btnVallen.Enabled = true;
                    controller.toggleButton(true);
                    lblTeWinnen.Text = controller.MogelijkeWinst.ToString();
                    controller.trapdoorReset();

                    break;
                case 3:
                    lblRonde3.ForeColor = Color.Green;
                    btnVallen.Enabled = true;
                    controller.toggleButton(true);
                    lblTeWinnen.Text = controller.MogelijkeWinst.ToString();
                    controller.trapdoorReset();
                    break;
                case 4:
                   
                    lblRonde4.ForeColor = Color.Green;
                    btnVallen.Enabled = true;
                    controller.toggleButton(true);
                    lblTeWinnen.Text = controller.MogelijkeWinst.ToString();
                    controller.trapdoorReset();
                    break;
              case 5:
                    break;

            }
            
            
            lblAantalKrediet.Text = controller.Krediet.ToString();
            
        }

        public void errorUI()
        {
            lblStatus.Text = "Ongeldige inzet";
            lblStatus.ForeColor = Color.Red;
        }

        public void resetStatusLabel()
        {
          lblStatus.Text = "Inzetten";
          lblStatus.ForeColor = Color.Black;

        }
          
        private void btnVallen_Click(object sender, EventArgs e)
        {
            controller.moneyDrop();
            if (lblStatus.Text == "Inzetten")
            {
              btnVolgendeRonde.Visible = true;
              btnVallen.Enabled = false;
            }
            
        }

        private void grpBox_Enter(object sender, EventArgs e)
        {

        }

        private void btnInzet_Click(object sender, EventArgs e)
        {
            float inzet;

            if (float.TryParse(textBox1.Text, out inzet))
            {
                controller.UwInzet = inzet;
            }
            else
            {
                controller.UwInzet = 0;
            }

            controller.berekenAlles();
            
            
        }

        private void btnVolgendeRonde_Click(object sender, EventArgs e)
        {
            btnVolgendeRonde.Visible = false;
            controller.voegRondeToe();
        }
    }
}
       
