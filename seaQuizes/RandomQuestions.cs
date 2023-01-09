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
    public partial class RandomQuestions : Form
    {
        DataTable dt;
        SqlDataAdapter sq;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
        SqlCommand cmd;
        int score;
        string Correctanswer;
        public RandomQuestions()
        {
            InitializeComponent();
        }


        private void Random_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                con.Open();
                sq = new SqlDataAdapter("SELECT TOP 1 Category,Question,Option1,Option2,Option3,Option4,Correctanswer" +
                    " FROM Questionstbl ORDER BY NEWID ();  ", con);
                //sq = new SqlDataAdapter("SELECT* FROM Questionstbl ORDER BY RAND(ID) LIMIT 1;  ", con);
                

                sq.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.Columns.Add();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
                //if (e.RowIndex >= 0)
            //{
              //  DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                label1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                label2.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                option1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                option2.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                option3.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                option4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
               Correctanswer = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
           // }
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            if (option1.Text == Correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void option2_CheckedChanged(object sender, EventArgs e)
        {
            if (option2.Text == Correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void option3_CheckedChanged(object sender, EventArgs e)
        {
            if (option3.Text == Correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void option4_CheckedChanged(object sender, EventArgs e)
        {
            if (option4.Text == Correctanswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string Randomquiz = "Random questions";
            try
            {
                MessageBox.Show(score.ToString());
                con.Open();
                cmd = new SqlCommand("Insert into scorestbl(Scores,Category) Values('" + score + "','" + Randomquiz + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
