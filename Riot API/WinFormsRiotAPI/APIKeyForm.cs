using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRiotAPI
{
    public partial class APIKeyForm : Form
    {
        public string APIKey;

        public APIKeyForm()
        {
            InitializeComponent();
        }

        private void APIKeyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void APIKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            APIKey = APIKeyTextBox.Text;
        }
    }
}
