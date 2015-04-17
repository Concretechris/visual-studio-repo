using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                endDate.SelectedDate = DateTime.Today.Date;
                startDate.SelectedDate = DateTime.Today.Date.AddDays(14);
                newEndDate.SelectedDate = DateTime.Today.Date.AddDays(21);
            }
        }

        protected void endDate_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            TimeSpan project_length = newEndDate.SelectedDate - startDate.SelectedDate;
            int budget = project_length.Days * 500;

            DateTime today = DateTime.Today;

            if (startDate.SelectedDate < today.AddDays(14))
            {
                resultLabel.Text = "Error: Must allow at least two weeks between previous assignment and new assignment";
                startDate.SelectedDate = today.AddDays(14);
            }
            else if (project_length.Days > 21)
            {
                budget = budget + 1000;
                resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}.", spyName.Text, assignmentName.Text, budget);
            }
            else
            {
                resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}.", spyName.Text, assignmentName.Text, budget);
            }
        }
    }
}