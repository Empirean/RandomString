using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomString
{

    public partial class Form1 : Form
    {
        RandomGen rng;
        public Form1()
        {
            InitializeComponent();
            rng = new RandomGen();
            txtLength.Value = rng.getMaxLength();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            txtOutput.Text = rng.getString();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            rng.setMaxLength((int) txtLength.Value);
            rng.addSymbols(txtSymbols.Text);

            MessageBox.Show("Applied", "Notice", MessageBoxButtons.OK);
        }
    }
}
