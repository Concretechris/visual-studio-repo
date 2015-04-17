using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssetTracker_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            string[] assetName = new string[0];
            double[] elections = new double[0];
            double[] subterfuge = new double[0];
            ViewState.Add("Assets", assetName);
            ViewState.Add("Elections", elections);
            ViewState.Add("Subterfuge", subterfuge);
            }

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string[] assetName = (string[])ViewState["Assets"];
            double[] elections = (double[])ViewState["Elections"];
            double[] subterfuge = (double[])ViewState["Subterfuge"];

            Array.Resize(ref assetName, assetName.Length + 1);
            Array.Resize(ref elections, elections.Length + 1);
            Array.Resize(ref subterfuge, subterfuge.Length + 1);

            int newAsset = assetName.GetUpperBound(0);
            int numElections = elections.GetUpperBound(0);
            int numSubterfuge = subterfuge.GetUpperBound(0);

            assetName[newAsset] = (String)nameTextBox.Text;
            elections[numElections] = Double.Parse(electionsTextBox.Text);
            subterfuge[numSubterfuge] = Double.Parse(subTextBox.Text);

            ViewState["Assets"] = assetName;
            ViewState["Elections"] = elections;
            ViewState["Subterfuge"] = subterfuge;


            resultLabel.Text = String.Format("Total Elections Rigged: {0}<br /> Average acts of subterfuge per Asset: {1:0.00}<br /> (Last Asset you added: {2})", elections.Sum(), subterfuge.Average(), nameTextBox.Text);
        }
    }
}