using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TripToTheMoon
  {
  public partial class Form1 : Form
    {
    public Form1()
      {
      InitializeComponent();
      departureDateMonthCalendar.MinDate = DateTime.Today;
      }

    private void DepartureDateMonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
      {
      if (departureDateMonthCalendar.SelectionStart.DayOfWeek.Equals(Day.Saturday))

      }
    }
  }