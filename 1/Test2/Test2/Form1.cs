using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            int a = 10;
            int b = 2 % 3;
            int c = a / b;

            /*lblContent.Text = a.ToString();
            lblContent.Text += b.ToString();
            lblContent.Text += c.ToString();*/

            /*string message = string.Format("{0}\n{1}\n{2}", a, b, c);
            lblContent.Text = message;*/

            /*string message = "{a}/n{b}/n{c}";
            lblContent.Text = message;*/

            string message = $"{a}\n{b}\n{c}";
            lblContent.Text = message;

        }
    }
}
