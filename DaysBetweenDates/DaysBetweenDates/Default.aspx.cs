using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void myCalendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime firstDate = myCalendar1.SelectedDate;
        }

        protected void myCalendar2_SelectionChanged(object sender, EventArgs e)
        {
            DateTime secondDate = myCalendar2.SelectedDate;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DateTime firstDate = myCalendar1.SelectedDate;
            DateTime secondDate = myCalendar2.SelectedDate;
            TimeSpan myResult;

            if (firstDate > secondDate)
            {
                myResult = firstDate - secondDate;
            }
            else
            {
                myResult = secondDate - firstDate;

            }
            resultLabel.Text = (myResult.TotalDays) + "";
        }
    }
}