using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

     

        private void Play_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void BtnRules_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameRules GR = new GameRules();
            GR.ShowDialog();
        }
    }
}
