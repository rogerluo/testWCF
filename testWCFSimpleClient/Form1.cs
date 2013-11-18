using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testWCFSimpleClient.SimpleMathService;

namespace testWCFSimpleClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnActoin_Click(object sender, EventArgs e)
        {
            lblResult.Text = "= ?";
            Int32 lhs, rhs, ret = 0;
            if (Int32.TryParse(tbxLhs.Text, out lhs) == false ||
                Int32.TryParse(tbxRhs.Text, out rhs) == false)
            {
                MessageBox.Show("Invalid Argurment");
                return;
            }

            MathServiceClient client = new MathServiceClient();

            if (cmbOperation.Text == "+")
            {
                ret = client.Add(lhs, rhs);
            }
            else if (cmbOperation.Text == "-")
            {
                ret = client.Subtract(lhs, rhs);
            }
            else if (cmbOperation.Text == "*")
            {
                ret = client.Multify(lhs, rhs);
            }
            else if (cmbOperation.Text == "/")
            {
                ret = client.Divide(lhs, rhs);
            }

            lblResult.Text = string.Format("= {0}", ret);
        }
    }
}
