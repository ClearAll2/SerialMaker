using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Serial_Maker
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            stbBase.Select();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                stbPass.Text = Encryption.MakePassword(stbBase.Text.Replace("-", String.Empty), txtIdentifier.Text);
                stbPass.Text = stbPass.Text.Insert(5, "-");
                stbPass.Text = stbPass.Text.Insert(11, "-");
                stbPass.Text = stbPass.Text.Insert(17, "-");
                stbPass.Text = stbPass.Text.Insert(23, "-");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Can't make password\n" + ex.Message);
            }
        }
    }
}