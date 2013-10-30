using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormatTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                switch(cboInput.Text) {
                    case "DateTime.Now":
                        txtOutput.Text = DateTime.Now.ToString(txtFormat.Text);
                        break;
                    default:
                        //txtOutput.Text =  String.Format( cboInput.Text.tost
                        break;
                }
            }
            catch (Exception e)
            {
                txtOutput.Text = e.Message;
            }
        }

    }
}
