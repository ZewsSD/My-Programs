using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cattckbutton
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        int score;
        int timerIdle;
        Random random;

        private void Form1_Load(object sender, EventArgs e)
        {
            score = 0;
            labelScore.Text = score.ToString();

            random = new Random();

            timerIdle = 1000;
            timerMove.Interval = timerIdle;
            timerMove.Enabled = true;

            buttonGoal.BringToFront();
        }

        private void timerMove_Tick(object sender, EventArgs e)
        {
            int x = this.Size.Width - buttonGoal.Size.Width;
            int y = this.Size.Height - buttonGoal.Size.Height;

            Point buttonPosition = new Point();

            buttonPosition.X = random.Next(0, x + 1);
            buttonPosition.Y = random.Next(0, y + 1);

            buttonGoal.Location = buttonPosition;
        }

        private void buttonGoal_MouseDown(object sender, MouseEventArgs e)
        {
            score++;
            labelScore.Text = score.ToString();

            if (timerIdle > 100)
            {
                timerIdle -= 10;
                timerMove.Interval = timerIdle;
            }
            buttonGoal.Location = new Point(-100,-100);
        }
    }
}
