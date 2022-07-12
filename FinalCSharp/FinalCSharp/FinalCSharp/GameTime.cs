using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCSharp
{
    class GameTime
    {
        public PictureBox ptbProgressBar;
        public Label lbPercent;
        public static int percent;
        public int maxWidth = 505;
        public GameTime(PictureBox ptbProgressBar, Label lbPercent)
        {
            this.ptbProgressBar = ptbProgressBar;
            this.lbPercent = lbPercent;
            NewGame();
        }

        public void NewGame()
        {
            if (Cons.NEWGAME) { percent = 100; ptbProgressBar.Width = maxWidth; }
            else
            {
                ptbProgressBar.Width = percent * maxWidth / 100;
            }    
            LifeTimePaint();
        }
        public void LifeTimePaint()
        {

            if (percent > 80) ptbProgressBar.BackColor = Color.Lime;
            else if (percent > 60) ptbProgressBar.BackColor = Color.GreenYellow;
            else if (percent > 40) ptbProgressBar.BackColor = Color.Yellow;
            else if (percent > 20)
            {
                ptbProgressBar.BackColor = Color.Tomato;
            }
            else ptbProgressBar.BackColor = Color.Red;
            if (ptbProgressBar.Width > 0)
            {
                percent = ptbProgressBar.Width * 100 / maxWidth;
                if (percent == 0) percent = 1;
            }
            else percent = 0;
            if (percent > 9)
                lbPercent.Text = " " + percent.ToString() + "%";
            else
                lbPercent.Text = "  " + percent.ToString() + "%";
        }

        public void UpdateLifeTime()
        {
            if (ptbProgressBar.Width > 0)
            {
                ptbProgressBar.Width--;
                LifeTimePaint();
            }
        }
    }
}
