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
    public partial class ScoreBoard : Form
    {
        DataTable dt;
        SqlDataAdapter sq;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");

        public ScoreBoard()
        {
            InitializeComponent();
        }

        private void ScoreBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizgameDataSet3.Scorestbl' table. You can move, or remove it, as needed.
           // this.scorestblTableAdapter.Fill(this.quizgameDataSet3.Scorestbl);
            // TODO: This line of code loads data into the 'quizgameDataSet1.Reptilestbl' table. You can move, or remove it, as needed.
            //this.reptilestblTableAdapter.Fill(this.quizgameDataSet1.Reptilestbl);
            //fillchart();
        }

        private void DisplayScores_Click(object sender, EventArgs e)
        {
            con.Open();
            //string qry = "select Registrationtbl.FirstName, Scorestbl.Category, Scorestbl.Scores from Registrationtbl inner join Scorestbl on Scorestbl.FirstName = Registrationtbl.FirstName";
            string qry = "select FirstName, Category, Scores from Registrationtbl, Scorestbl";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dataGridView1.DataSource = dt;
            da.Fill(dt);
            con.Close();
            Fillchart();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
        }
        void Fillchart()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
             DataTable dt = new DataTable();
             con.Open();
            //SqlDataAdapter da = new SqlDataAdapter("select Registrationtbl.FirstName,Scorestbl.Category, Scorestbl.Scores from Registrationtbl inner join Scorestbl on Scorestbl.FirstName = Registrationtbl.FirstName", con);
            SqlDataAdapter da = new SqlDataAdapter("select FirstName, Category, Scores from Registrationtbl, Scorestbl", con);
            da.Fill(dt);
            chart1.DataSource = dt;
            con.Close();
            try
            {
                chart1.Series["Scores"].XValueMember = "FirstName";
                chart1.Series["Scores"].YValueMembers = "Scores";
                chart1.Titles.Add("Scores Chart");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
