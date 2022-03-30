﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform2_HwangJaeGyu
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            if (false == chkFloatType.Checked)//정수
            {
                //(err)lblResult.Text = tbxOpr1.Text + tbxOpr2.Text;
                //(err)lblResult.Text = (int)tbxOpr1.Text + (int)tbxOpr2.Text;

                int opr1 = int.Parse(tbxOpr1.Text);
                int opr2 = int.Parse(tbxOpr2.Text);
                int result = opr1 + opr2;

                //lblResult.Text = (string)result;
                lblResult.Text = result.ToString();
            }
            else //실수, floating point number
            {
                double opr1 = double.Parse(tbxOpr1.Text);
                double opr2 = double.Parse(tbxOpr2.Text);
                double result = opr1 + opr2;
                lblResult.Text = result.ToString();
            }
        }
    }
}
