using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace seaQuizes
{
    public partial class Form1 : Form
    {
        System.Timers.Timer t;
        int h, m, s, ms;
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }
        private void customizeDesign()
        {
            pnlQuiz.Visible = false;
        }

        private void BtnChooseCategory_Click(object sender, EventArgs e)
        {
            showpanel(pnlQuiz);
        }

        public void hidepanel()
        {
            if (pnlQuiz.Visible == true)
                pnlQuiz.Visible = false;
        }
        public void showpanel(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hidepanel();
                Submenu.Visible = true;
            }
            else
            {
                Submenu.Visible = false;
            }
        }

        private void BtnFish_Click(object sender, EventArgs e)
        {
            openNewForm(new Fishfrm());
            lblname.Text = "Fish Category";
            lbltime.Visible = true;
            t.Start();
        }

        private void BtnReptiles_Click(object sender, EventArgs e)
        {
            lblname.Text = "Reptiles Category";
            openNewForm(new Reptilesfrm());
            lbltime.Visible = true;
            t.Start();
        }

        private Form activeForm = null;

        private void Scores_Click(object sender, EventArgs e)
        {
            lblname.Text = "Scores";
            openNewForm(new ScoreBoard());
        }

        private void btnRandomquizes_Click(object sender, EventArgs e)
        {
            lblname.Text = "Answer Random Questions";
            openNewForm(new RandomQuestions());
            t.Start();
        }

        private void BQuestions(object sender, EventArgs e)
        {
            lblname.Text = "Ask Questions";
            openNewForm(new Questions());
            t.Start();
        }

        private void BtnBirds(object sender, EventArgs e)
        {
            lblname.Text = "Birds Category";
            openNewForm(new Birds());
            t.Start();
        }

        private void openNewForm(Form NewForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = NewForm;
            NewForm.TopLevel = false;
            NewForm.FormBorderStyle = FormBorderStyle.None;
            NewForm.Dock = DockStyle.Fill;
            pnlPages.Controls.Add(NewForm);
            pnlPages.Tag = NewForm;
            NewForm.BringToFront();
            NewForm.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1;
            t.Elapsed += OnTimeEvent;
        }
        private void OnTimeEvent(object sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;
                if (ms == 60)
                {
                    ms = 0;
                    s += 1;
                }
                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }
                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }
                lbltime.Text = string.Format("{0}:{1}:{2}:{3}",
                    h.ToString().PadLeft(2, '0'),
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'),
                    ms.ToString().PadLeft(2, '0'));
            }));
            if (m == 5)
            {
                t.Stop();
                //lbltimeup.Visible = true;
                MessageBox.Show("time's up", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }
    }
}
