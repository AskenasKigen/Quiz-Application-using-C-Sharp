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
    public partial class Fishfrm : Form
    {
        DataTable dt;
        SqlDataAdapter sq;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
        SqlCommand cmd;
        int score;
        string correctanswer;
        int answer;
        List<int> scores;
        
        public Fishfrm()
        {
            InitializeComponent();
            scores = new List<int>();
            score = 0;
        }
        
        private void Fishfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizgameDataSet.Fishtbl' table. You can move, or remove it, as needed.
            this.fishtblTableAdapter.Fill(this.quizgameDataSet.Fishtbl);
            display();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                Option1.Text = row.Cells[2].Value.ToString();
                Option2.Text = row.Cells[3].Value.ToString();
                Option3.Text = row.Cells[4].Value.ToString();
                Option4.Text = row.Cells[5].Value.ToString();
                correctanswer = row.Cells[6].Value.ToString();
            }
        }

        private void SaveAnswers_Click(object sender, EventArgs e)
        {
            string Category = "Fish";
            try
            {
                MessageBox.Show("Your Score is",score.ToString(),MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Open();
            cmd = new SqlCommand("Insert into scorestbl(Scores, Category) Values('" + score+ "','"+ Category +"')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void display()
        {
            dt = new DataTable();
            con.Open();
            sq = new SqlDataAdapter("select * from Fishtbl", con);
            sq.Fill(dt);
            dataGridView1.DataSource = dt;
            dt.Columns.Add();
            con.Close();

        }

        private void Option1_CheckedChanged(object sender, EventArgs e)
        {
            if (Option1.Text == correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void Option2_CheckedChanged(object sender, EventArgs e)
        {
            if (Option2.Text == correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void Option3_CheckedChanged(object sender, EventArgs e)
        {
            if (Option3.Text == correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void Option4_CheckedChanged(object sender, EventArgs e)
        {
            if (Option4.Text == correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }
       
        
    }
    
    
}
