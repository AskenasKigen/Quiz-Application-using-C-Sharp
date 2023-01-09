using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seaQuizes
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            //progressBar1.Value = progressBar1.Value;
            if (progressBar1.Value == 100)
            {

                Form1 frm = new Form1();
                frm.Show();

                this.Hide();
                timer1.Enabled = false;

            }
        }
    }
}
