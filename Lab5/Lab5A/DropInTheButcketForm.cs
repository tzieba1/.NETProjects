using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5A
{
  public partial class DropInTheBucketForm : Form
  {
    public DropInTheBucketForm()
    {
      InitializeComponent();
    }
    //Initialize constants.
    private const float PEN_WIDTH = 1.0f;
    
    //Private instance variables.
    private Pen whitePen = new Pen(Color.White, PEN_WIDTH);
    private SolidBrush blackBrush = new SolidBrush(Color.Black);
    private Color liquidColor = Color.Aqua;

    //Initial line height for first line to be drawn at bottom of bucket.
    private int yValue = 374;

    private void ColorButton_Click(object sender, EventArgs e)
    {
      //Handling the case when user clicks cancel or exits the dialog.
      DialogResult colorDialogResult = LiquidColorDialog.ShowDialog();
      if( colorDialogResult != DialogResult.Cancel)
        liquidColor = LiquidColorDialog.Color;
    }

    private void SpeedTrackBar_Scroll(object sender, EventArgs e)
    {
      //Timer must be disabled whenever the TrackBar scroll is at left hand side.
      if (SpeedTrackBar.Value == 0)
        AnimationTimer.Enabled = false;
      //When Timer is enabled, Interval decreases multiplicatively depending on TrackBar Value.
      else
      {
        AnimationTimer.Enabled = true;
        AnimationTimer.Interval = SpeedTrackBar.Value == 20 ? 1 : (20 - SpeedTrackBar.Value) * 4;
      }
    }

    private void AnimationTimer_Tick(object sender, EventArgs e)
    {
      //Graphics objects for drawing lines.
      Graphics g = DrawingPanel.CreateGraphics();
      if (yValue < 155)
      {
        //Clear lines and liquid stream with rectangles.
        yValue = 374;
        g.FillRectangle(blackBrush, 91, 150, 249, 225); 
        g.FillRectangle(blackBrush, 215, 118, 25, 256);

        //Reset the TrackBar and Timer.
        SpeedTrackBar.Value = 0;
        AnimationTimer.Enabled = false;
      }
      else
      {
        //Drawing a line at each tick interval.
        Line nextLine = new Line(91, yValue, 339, yValue, liquidColor);
        nextLine.Draw(g);
        //Liquid stream must be redrawn according to the color change.
        g.FillRectangle(new SolidBrush(liquidColor), 215, 118, 25, yValue - 118);
      }
      yValue--;

      //Disposing Graphics object after drawing a line on or resetting the DrawingPanel.
      g.Dispose();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void DrawingPanel_Paint(object sender, PaintEventArgs e)
    {
      //Graphics object for this paint event.
      Graphics g = e.Graphics;

      //Creating the points of a bucket and drawing it to the DrawingPanel.
      Point[] bucketPoints = { new Point(90, 150), new Point(90, 375), new Point(340, 375), new Point(340, 150) };
      g.DrawCurve(whitePen, bucketPoints, 0.0f);
      
      //Disposing Graphics object after drawing the bucket.
      g.Dispose();
    }
  }
}
