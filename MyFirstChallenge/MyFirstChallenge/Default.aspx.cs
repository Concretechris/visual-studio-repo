using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Age = ageField.Text;
            string Money = moneyField.Text;

            string result = "At " + Age + " years old, I would have expected you to have more than " + Money + " dollars in your pocket.";
            resultLabel.Text = result;
        }
    }
}