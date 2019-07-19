using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lab10__300982276_
{
    public partial class MainForm : Form
    {
        public Form parent { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void NextMainButton_Click(object sender, EventArgs e)
        {
            EndForm endForm = new EndForm();
            endForm.parent = this;
            endForm.Show();
            this.Hide();
            //this.parent.Show();
            //this.Hide();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.parent.Show();
            //this.Hide();

            Application.Exit();
        }
    }
}
