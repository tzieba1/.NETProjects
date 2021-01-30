using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawIt
{
    public partial class Form1 : Form
    {
        const int LINE_DEPTH = 30;

        Random rnd;
        int x1, y1, x2, y2;
        int x1inc, y1inc, x2inc, y2inc;

        private void IntervalTrackBar_Scroll(object sender, EventArgs e)
        {
            AnimationTimer.Interval = IntervalTrackBar.Value;
            IntervalLabel.Text = IntervalTrackBar.Value + " ms";
        }

        List<Line> lines;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            lines = new List<Line>();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (StartButton.Text == "Start")
            {
                AnimationTimer.Enabled = true;
                StartButton.Text = "Stop";
                x1 = rnd.Next(0, DrawingPanel.Width);
                x2 = rnd.Next(0, DrawingPanel.Width);
                y1 = rnd.Next(0, DrawingPanel.Height);
                y2 = rnd.Next(0, DrawingPanel.Height);
                x1inc = rnd.Next(4, 15);
                x2inc = rnd.Next(4, 15);
                y1inc = rnd.Next(4, 15);
                y2inc = rnd.Next(4, 15);
                Graphics g = DrawingPanel.CreateGraphics();
                g.Clear(Color.Black);   // Clear the screen
                g.Dispose();
                lines = new List<Line>();

            }
            else
            {
                AnimationTimer.Enabled = false;
                StartButton.Text = "Start";
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Color lc = Color.LightGreen;
            Line line = new Line(x1, y1, x2, y2, lc);
            lines.Add(line);

            // Draw the line on screen
            Graphics g = DrawingPanel.CreateGraphics();

            if (lines.Count == LINE_DEPTH)
            {
                lines[0].LineColor = Color.Black;
                lines[0].Draw(g);
                lines.RemoveAt(0);
            }


            foreach (Line l in lines)
            {
                l.Draw(g);
                l.Fade();
            }

            g.Dispose();

            // Move the line
            x1 += x1inc;
            y1 += y1inc;
            x2 += x2inc;
            y2 += y2inc;

            // Check and reverse increments if required
            if (x1 < 0 || x1 > DrawingPanel.Width)
                x1inc = (x1inc > 0) ? -rnd.Next(4, 15) : rnd.Next(4, 15);
            if (x2 < 0 || x2 > DrawingPanel.Width)
                x2inc = (x2inc > 0) ? -rnd.Next(4, 15) : rnd.Next(4, 15);
            if (y1 < 0 || y1 > DrawingPanel.Height) 
                y1inc = (y1inc > 0) ? -rnd.Next(4, 15) : rnd.Next(4, 15);
            if (y2 < 0 || y2 > DrawingPanel.Height) 
                y2inc = (y2inc > 0) ? -rnd.Next(4, 15) : rnd.Next(4, 15);
        }
    }
}
