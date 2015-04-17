using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PapaBobsPizza
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (sizeSmall.Checked == true)
            {
                total = total + 10;
            }
            else if (sizeMedium.Checked == true)
            {
                total = total + 13;
            }
            else if (largeSize.Checked == true)
            {
                total = total + 16;
            }

            if (thickCrust.Checked == true)
            {
                total = total + 2;
            }

            if (pepperoni.Checked)
                {
                    total = total + 1.50;
                }

            if (onions.Checked || redpeppers.Checked)
            {
                total = total + 0.75;
            }

            if (greenpeppers.Checked)
            {
                total = total + 0.50;
            }

            if (redpeppers.Checked)
            {
                total = total + 0.75;
            }

            if (achovies.Checked)
            {
                total = total + 2.00;
            }

            if (pepperoni.Checked && greenpeppers.Checked && achovies.Checked)
            {
                total = total - 2.00;
            }

            if (pepperoni.Checked && redpeppers.Checked && onions.Checked)
            {
                total = total - 2.00;
            }

            resultLabel.Text = "$" + total + " ";
        }
    }
}