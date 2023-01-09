using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seaQuizes
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
        SqlCommand cmd;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
        }
        private Form activeForm = null;
        private void openNewForm(Form NewForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = NewForm;
            NewForm.TopLevel = false;
            NewForm.FormBorderStyle = FormBorderStyle.None;
            NewForm.Dock = DockStyle.Fill;
            pnlLoad.Controls.Add(NewForm);
            pnlLoad.Tag = NewForm;
            NewForm.BringToFront();
            NewForm.Show();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string firstname;
            firstname = txtFName.Text;

            try
            {
                con.Open();
                cmd = new SqlCommand("insert into Registrationtbl(FirstName) values('" + txtFName.Text + "')", con);
                cmd.ExecuteNonQuery();


                MessageBox.Show(firstname + " " , "Welcome",  MessageBoxButtons.OK, MessageBoxIcon.Information);


                clear();
               openNewForm(new Load());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            if (firstname == "")
            {
                MessageBox.Show("Please fill all the blanks", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clear()
        {
            txtFName.Clear();
        }
        
    }
    
}
