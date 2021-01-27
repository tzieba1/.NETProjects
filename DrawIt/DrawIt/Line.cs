using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIt
  {
  public class Line
    {
    public int X1 { get; }
    public int X2 { get; }
    public int Y1 { get; }
    public int Y2 { get; }
    public Color LineColor { get; set; }

    public Line(int x1, int y1, int x2, int y2, Color lineColor)
      {
      X1 = x1;
      Y1 = y1;
      X2 = x2;
      Y2 = y2;
      LineColor = lineColor;
      }

    public void Draw(Graphics g)
      {
      Pen p = new Pen(LineColor);
      g.DrawLine(p, X1, Y1, X2, Y2);
      }

    public void Fade()
      {
      const double DECAY_FACTOR = 0.95;
      LineColor = Color.FromArgb((int)(LineColor.R * DECAY_FACTOR), 
                                 (int)(LineColor.G * DECAY_FACTOR), 
                                 (int)(LineColor.B * DECAY_FACTOR));
      }
    }
  }
