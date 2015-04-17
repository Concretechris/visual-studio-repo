using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Note_Taking_Challenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void resultButton_Click(object sender, EventArgs e)
        {
            if (pencilButton.Checked == true)
            {
                resultLabel.Text = "You selected pencil";
                resultImage.ImageUrl = "Resources/pencil.png";
            }
            else if (penButton.Checked == true)
            {
                resultLabel.Text = "You selected pen";
                resultImage.ImageUrl = "Resources/pen.png";
            }
            else if (phoneButton.Checked == true)
            {
                resultLabel.Text = "You selected phone";
                resultImage.ImageUrl = "Resources/phone.png";
            }
            else if (tabletButton.Checked == true)
            {
                resultLabel.Text = "You selected tablet";
                resultImage.ImageUrl = "Resources/tablet.png";
            }
            else
            {
                resultLabel.Text = "Please select an option";
            }
        }
    }
}