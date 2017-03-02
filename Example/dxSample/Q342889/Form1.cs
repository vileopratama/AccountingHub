using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Q342889
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textEdit1.Text = String.Empty;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}
