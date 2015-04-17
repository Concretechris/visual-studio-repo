using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void AdditionButton_Click(object sender, EventArgs e)
        {
            string num1 = NumberOne.Text;
            string num2 = NumberTwo.Text;

            int result = int.Parse(num1) + int.Parse(num2);
            ResultLabel.Text = result.ToString();

        }

        protected void SubtractionButton_Click(object sender, EventArgs e)
        {
            string num1 = NumberOne.Text;
            string num2 = NumberTwo.Text;

            int result = int.Parse(num1)  - int.Parse(num2);
            ResultLabel.Text = result.ToString();
        }

        protected void MultiplyButton_Click(object sender, EventArgs e)
        {
            string num1 = NumberOne.Text;
            string num2 = NumberTwo.Text;

            int result = int.Parse(num1) *+ int.Parse(num2);
            ResultLabel.Text = result.ToString();
        }

        protected void DivisionButton_Click(object sender, EventArgs e)
        {
            string num1 = NumberOne.Text;
            string num2 = NumberTwo.Text;

            double result = double.Parse(num1) / double.Parse(num2);
            ResultLabel.Text = result.ToString();
        }

        protected void NumberOne_TextChanged(object sender, EventArgs e)
        {

        }
    }
}