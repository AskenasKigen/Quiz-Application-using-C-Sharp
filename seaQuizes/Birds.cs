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
    public partial class Birds : Form
    {
        DataTable dt;
        SqlDataAdapter sq;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
        SqlCommand cmd;
        string CorrectAnswer;
        int score;
        public Birds()
        {
            InitializeComponent();
        }

        private void btnShowquiz_Click(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                sq = new SqlDataAdapter("select * from Birdstbl", con);
                sq.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.Columns.Add();
                dt.Columns.Add();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public class SeaAnimals : ISeaLive
        {
            string q;
            public void Fly()
            {
                q = "which bird flies the highest?";
                List<string> ans = new List<string>();
                {
                    //string a;
                    ans.Add("vulture");
                    ans.Add("duck");
                    ans.Add("pegion");
                    ans.Add("Eagle");

                };
            }

            public void Swim()
            {
                //throw new NotImplementedException();
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                option1.Text = row.Cells[2].Value.ToString();
                option2.Text = row.Cells[3].Value.ToString();
                option3.Text = row.Cells[4].Value.ToString();
                option4.Text = row.Cells[5].Value.ToString();
                CorrectAnswer = row.Cells[6].Value.ToString();
            }
        }

        private void option1_CheckedChanged(object sender, EventArgs e)
        {
            if (option1.Text == CorrectAnswer)
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
            if (option2.Text == CorrectAnswer)
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
            if (option3.Text == CorrectAnswer)
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
            if (option4.Text == CorrectAnswer)
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            lblScores.Text = score.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            string Category = "Birds";
            try
            {
                MessageBox.Show(score.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Open();
            cmd = new SqlCommand("Insert into scorestbl(Scores, Category) Values('" + score + "','" + Category + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Birds_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizgameDataSet2.Birdstbl' table. You can move, or remove it, as needed.
            this.birdstblTableAdapter.Fill(this.quizgameDataSet2.Birdstbl);

        }
    }
}
