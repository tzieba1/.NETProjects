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

    Random rand;
    int x1, x2, y1, y2;
    int x1inc, y1inc, x2inc, y2inc;

    private void IntervalTrackBar_Scroll(object sender, EventArgs e)
      {
      AnimationTimer.Interval = IntervalTrackBar.Value;
      IntervalLabel.Text = IntervalTrackBar.Value + "ms";
      }

    List<Line> lines;
    public Form1()
      {
      InitializeComponent();
      rand = new Random();
      lines = new List<Line>();
      }

    private void StartButton_Click(object sender, EventArgs e)
      {
      //Toggle button for start/stop.
      if (StartButton.Text == "Start")
        {
        AnimationTimer.Enabled = true;
        StartButton.Text = "Stop";
        x1 = rand.Next(0, DrawingPanel.Width);
        x2 = rand.Next(0, DrawingPanel.Width);
        y1 = rand.Next(0, DrawingPanel.Height);
        y2 = rand.Next(0, DrawingPanel.Height);
        x1inc = rand.Next(4, 15);
        x2inc = rand.Next(4, 15);
        y1inc = rand.Next(4, 15);
        y2inc = rand.Next(4, 15);

        Graphics g = DrawingPanel.CreateGraphics();
        g.Clear(Color.Black);
        g.Dispose();
        }
      else
        {
        AnimationTimer.Enabled = false;
        StartButton.Text = "Start";
        }
      }

    private void DrawCurvePoint(PaintEventArgs e)
    {

      // Create pens.
      Pen redPen = new Pen(Color.Red, 3);
      Pen greenPen = new Pen(Color.Green, 3);

      // Create points that define curve.
      Point point1 = new Point(50, 50);
      Point point2 = new Point(100, 25);
      Point point3 = new Point(200, 5);
      Point point4 = new Point(250, 50);
      Point point5 = new Point(300, 100);
      Point point6 = new Point(350, 200);
      Point point7 = new Point(250, 250);
      Point[] curvePoints = { point1, point2, point3, point4, point5, point6, point7 };

      // Draw lines between original points to screen.
      e.Graphics.DrawLines(redPen, curvePoints);

      // Draw curve to screen.
      e.Graphics.DrawCurve(greenPen, curvePoints);
    }

    private void AnimationTimer_Tick(object sender, EventArgs e)
      {
      Color lc = Color.Green;
      Line line = new Line(x1, y1, x2, y2, lc);
      lines.Add(line);

      //Draw the line of the screen.
      Graphics g = DrawingPanel.CreateGraphics();
      if(lines.Count == LINE_DEPTH)
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

      //Move the line.
      x1 += x1inc;
      x2 += x2inc;
      y1 += y1inc;
      y2 += y2inc;

      if (x1 < 0 || x1 > DrawingPanel.Width) { x1inc = (x1inc > 0) ? -rand.Next(4,15): rand.Next(4,15); }
      if (x2 < 0 || x2 > DrawingPanel.Width) { x2inc = (x2inc > 0) ? -rand.Next(4,15): rand.Next(4,15); }
      if (y1 < 0 || y1 > DrawingPanel.Height) { y1inc = (y1inc > 0) ? -rand.Next(4,15) : rand.Next(4,15); }
      if (y2 < 0 || y2 > DrawingPanel.Height) { y2inc = (y2inc > 0) ? -rand.Next(4,15) : rand.Next(4,15); }
      
      }
    }
  }
