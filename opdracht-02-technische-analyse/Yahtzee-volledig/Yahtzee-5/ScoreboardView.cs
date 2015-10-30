using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_5
{
    public partial class ScoreboardView : UserControl
    {
        /*
            Member die de scoreboard controller onthoudt
        */
        private ScoreboardController controller;

        /*
            Constructor
        */
        public ScoreboardView( ScoreboardController c)
        {
            // Vang de geïnjecteerde controller op
            controller = c;
            InitializeComponent();
        }

        /*
            Methode die uitgevoerd wordt bij het inladen van de scoreboard view
        */
        private void ScoreboardView_Load(object sender, EventArgs e)
        {
            // Toon het maximum aantal worpen in het overeenstemmende label
            maxWorpenLabel.Text = controller.MaximumAantalWorpen.ToString();

            // Toon het huidig aantal worpen in het overeenstemmende label
            aantalWorpenValueLabel.Text = controller.HuidigAantalWorpen.ToString();
        }

        /*
            Methode die uitgevoerd wordt wanneer er iets wijzigt
        */
        public void updateView()
        {
            // Haal het nieuwe aantal worpen op
            aantalWorpenValueLabel.Text = controller.HuidigAantalWorpen.ToString();
            scoreValueLabel.Text = controller.SomAantalOgen.ToString();
            if (controller.HuidigAantalWorpen == controller.MaximumAantalWorpen)
            {
              controller.checkHighscore();
              highscoreValueLabel.Text = controller.Highscore.ToString();
            }
        }
    }
}
