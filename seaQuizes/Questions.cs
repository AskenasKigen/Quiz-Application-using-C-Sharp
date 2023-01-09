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
    public partial class Questions : Form
    {
        DataTable dt;
        SqlDataAdapter sq;
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RVMV1RJ\SQLEXPRESS;Initial Catalog=quizgame;Integrated Security=True");
        SqlCommand cmd;
        public Questions()
        {
            InitializeComponent();
        }

        private void Questions_Load(object sender, EventArgs e)
        {

        }
        public void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                sq = new SqlDataAdapter("select * from Questionstbl", con);
                sq.Fill(dt);
                dataGridView1.DataSource = dt;
                dt.Columns.Add();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void SaveQuiz_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Questionstbl values" +
                    "(@Category,@Questions,@Option1,@Option2,@Option3,@Option4,@Correctanswer)", con);


                cmd.Parameters.AddWithValue("@Category", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Questions", textBox2.Text);
                cmd.Parameters.AddWithValue("@Option1", textBox3.Text);
                cmd.Parameters.AddWithValue("@Option2", textBox4.Text);
                cmd.Parameters.AddWithValue("@Option3", textBox5.Text);
                cmd.Parameters.AddWithValue("@Option4", textBox6.Text);
                cmd.Parameters.AddWithValue("@Correctanswer", textBox7.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                display();

                if (comboBox1.Text == "Fish")
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Fishtbl(Questions,Option1,Option2,Option3,Option4,Correctanswer)" +
                        " Values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," +
                        "'" + textBox6.Text + "','" + textBox7.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (comboBox1.Text == "Birds")
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Birdstbl(Question,Option1,Option2,Option3,Option4,CorrectAnswer)" +
                        " Values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," +
                        "'" + textBox6.Text + "','" + textBox7.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else if (comboBox1.Text == "Reptiles")
                {
                    con.Open();
                    cmd = new SqlCommand("Insert into Reptilestbl(Question,Option1,Option2,Option3,Option4,CorrectAnswer) " +
                        "Values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," +
                        "'" + textBox6.Text + "','" + textBox7.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Error", "Choose category", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

                MessageBox.Show("Successfully Saved!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
