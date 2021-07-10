using ConsumerAPIServices.Shared;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConsumerAPIServices.Forms
{
    public partial class CallAPI : Form
    {
        public CallAPI()
        {
            InitializeComponent();
            MaximumSize = new Size(500, 500);
        }

        private async void btnGetALL_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.GetAll();
            txtResponse.Text = RestHelper.IdentJSON(response);
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Post(txtName.Text,txtJob.Text);
            txtResponse.Text = RestHelper.IdentJSON(response);
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Get(txtId.Text);
            txtResponse.Text = RestHelper.IdentJSON(response);
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Put(txtId.Text, txtName.Text, txtJob.Text);
            txtResponse.Text = RestHelper.IdentJSON(response);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.Delete(txtId.Text);
            txtResponse.Text = response;
        }
    }
}
