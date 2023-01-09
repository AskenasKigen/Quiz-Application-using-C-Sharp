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
    public partial class Reptilesfrm : Form
    {
        DataTable dt;
        SqlDataAdapter sq;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
        SqlCommand cmd;
        string question1;
        string question2;
        string question3;
        string CorrectAnswer;
        int score;
        public Reptilesfrm()
        {
            InitializeComponent();
        }

        private void Reptilesfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizgameDataSet7.Reptilestbl' table. You can move, or remove it, as needed.
            this.reptilestblTableAdapter.Fill(this.quizgameDataSet7.Reptilestbl);

        }
        public Reptiles loadreptile(Reptiles reptl)
        {
            question1 = "Which animal is is shown in the picture? ";
            question2 = "What is the name of this sea animal?";
            question3 = "Which part does this sea animal breathe?";
            reptl = new Reptiles(question1, question2, question3);
            return reptl;


        }
        public void display()
        {
            if ((textBox1.Text == "") && (textBox2.Text == "") && (textBox3.Text == ""))
            {
                MessageBox.Show("please fill all blanks!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            dt = new DataTable();
            con.Open();
            sq = new SqlDataAdapter("select * from Reptilestbl", con);
            sq.Fill(dt);
            dataGridView1.DataSource = dt;
            dt.Columns.Add();
            con.Close();
        }
        

        private void showdb_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            try
            {
                con.Open();

                cmd = new SqlCommand("Insert into Reptilestbl(Question,Option1,Option2,Option3,Option4,CorrectAnswer) values('" + lblquiz1.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Insert into Reptilestbl(Question,Option1,Option2,Option3,Option4,CorrectAnswer) values('" + lblquiz2.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + textBox2.Text + "')", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Insert into Reptilestbl(Question,Option1,Option2,Option3,Option4,CorrectAnswer) values('" + lblquiz3.Text + "','" + "" + "','" + "" + "','" + "" + "','" + "" + "','" + textBox3.Text + "')", con);
                cmd.ExecuteNonQuery();

                con.Close();
                display();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            scores();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "shark")
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "tilapia")
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "lungs")
            {
                score += 1;
            }
            else
            {
                score += 0;
            }
            
        }
        private void scores()
        {
            string Reptile = "Reptile";
            try
            {
                MessageBox.Show(score.ToString());
                con.Open();
                cmd = new SqlCommand("Insert into scorestbl(Scores,Category) Values('" + score + "','" + Reptile +"')", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void startquiz_Click(object sender, EventArgs e)
        {
            Reptiles reptile = new Reptiles();
            pictureBox1.Visible = true;
            lblquiz1.Visible = true;
            textBox1.Visible = true;
            lblquiz2.Visible = true;
            pictureBox2.Visible = true;
            textBox2.Visible = true;
            lblquiz3.Visible = true;
            pictureBox3.Visible = true;
            textBox3.Visible = true;
            Reptiles loadreptle = loadreptile(reptile);
            string question1 = loadreptle.Question1();
            lblquiz1.Text = question1;
            string question2 = loadreptle.Question2();
            lblquiz2.Text = question2;
            string question3 = loadreptle.Question3();
            lblquiz3.Text = question3;
        }
    }
}