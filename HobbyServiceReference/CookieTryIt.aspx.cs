using System;

namespace Assignment5
{
    public partial class CookieTryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCurrentSummary();
            }
        }

        private void LoadCurrentSummary()
        {
            var summary = CookieHelper.LoadCollectionSummary();
            lblCurrentSummary.Text = $"Current: Collector='{summary.username}', Recent='{summary.recentPurchase}', Value=${summary.totalValue}, Items={summary.itemCount}";

            txtUsername.Text = summary.username;
            txtRecentPurchase.Text = summary.recentPurchase;
            txtTotalValue.Text = summary.totalValue.ToString();
            txtItemCount.Text = summary.itemCount.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string recentPurchase = txtRecentPurchase.Text;
            decimal totalValue = decimal.Parse(txtTotalValue.Text);
            int itemCount = int.Parse(txtItemCount.Text);

            CookieHelper.SaveCollectionSummary(username, recentPurchase, totalValue, itemCount);
            lblMessage.Text = "Collection summary saved!";

            LoadCurrentSummary();
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCurrentSummary();
            lblMessage.Text = "Collection summary loaded!";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            CookieHelper.DeleteCollectionSummary();
            lblMessage.Text = "Collection summary cleared!";
            LoadCurrentSummary();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}