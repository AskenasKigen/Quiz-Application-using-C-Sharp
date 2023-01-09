
namespace seaQuizes
{
    partial class Reptilesfrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.option4 = new System.Windows.Forms.RadioButton();
            this.option3 = new System.Windows.Forms.RadioButton();
            this.option2 = new System.Windows.Forms.RadioButton();
            this.option1 = new System.Windows.Forms.RadioButton();
            this.showdb = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.startquiz = new System.Windows.Forms.Button();
            this.lblquiz3 = new System.Windows.Forms.Label();
            this.lblquiz2 = new System.Windows.Forms.Label();
            this.lblquiz1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblScores = new System.Windows.Forms.Label();
            this.quizgameDataSet7 = new seaQuizes.quizgameDataSet7();
            this.reptilestblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reptilestblTableAdapter = new seaQuizes.quizgameDataSet7TableAdapters.ReptilestblTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctAnswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizgameDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptilestblBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Location = new System.Drawing.Point(342, 209);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(14, 13);
            this.option4.TabIndex = 27;
            this.option4.TabStop = true;
            this.option4.UseVisualStyleBackColor = true;
            this.option4.CheckedChanged += new System.EventHandler(this.option4_CheckedChanged);
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(105, 209);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(14, 13);
            this.option3.TabIndex = 28;
            this.option3.TabStop = true;
            this.option3.UseVisualStyleBackColor = true;
            this.option3.CheckedChanged += new System.EventHandler(this.option3_CheckedChanged);
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(342, 190);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(14, 13);
            this.option2.TabIndex = 29;
            this.option2.TabStop = true;
            this.option2.UseVisualStyleBackColor = true;
            this.option2.CheckedChanged += new System.EventHandler(this.option2_CheckedChanged);
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(105, 190);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(14, 13);
            this.option1.TabIndex = 30;
            this.option1.TabStop = true;
            this.option1.UseVisualStyleBackColor = true;
            this.option1.CheckedChanged += new System.EventHandler(this.option1_CheckedChanged);
            // 
            // showdb
            // 
            this.showdb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.showdb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showdb.ForeColor = System.Drawing.Color.Transparent;
            this.showdb.Location = new System.Drawing.Point(9, 167);
            this.showdb.Name = "showdb";
            this.showdb.Size = new System.Drawing.Size(81, 24);
            this.showdb.TabIndex = 26;
            this.showdb.Text = "Save";
            this.showdb.UseVisualStyleBackColor = false;
            this.showdb.Click += new System.EventHandler(this.showdb_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(367, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 25;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(367, 155);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 23;
            this.textBox3.Visible = false;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(367, 65);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 24;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // startquiz
            // 
            this.startquiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.startquiz.FlatAppearance.BorderSize = 0;
            this.startquiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startquiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.startquiz.Location = new System.Drawing.Point(13, 27);
            this.startquiz.Name = "startquiz";
            this.startquiz.Size = new System.Drawing.Size(75, 23);
            this.startquiz.TabIndex = 21;
            this.startquiz.Text = "Start quiz";
            this.startquiz.UseVisualStyleBackColor = false;
            this.startquiz.Click += new System.EventHandler(this.startquiz_Click);
            // 
            // lblquiz3
            // 
            this.lblquiz3.AutoSize = true;
            this.lblquiz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquiz3.Location = new System.Drawing.Point(90, 147);
            this.lblquiz3.Name = "lblquiz3";
            this.lblquiz3.Size = new System.Drawing.Size(0, 13);
            this.lblquiz3.TabIndex = 20;
            this.lblquiz3.Visible = false;
            // 
            // lblquiz2
            // 
            this.lblquiz2.AutoSize = true;
            this.lblquiz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquiz2.Location = new System.Drawing.Point(90, 108);
            this.lblquiz2.Name = "lblquiz2";
            this.lblquiz2.Size = new System.Drawing.Size(0, 13);
            this.lblquiz2.TabIndex = 19;
            this.lblquiz2.Visible = false;
            // 
            // lblquiz1
            // 
            this.lblquiz1.AutoSize = true;
            this.lblquiz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquiz1.Location = new System.Drawing.Point(88, 68);
            this.lblquiz1.Name = "lblquiz1";
            this.lblquiz1.Size = new System.Drawing.Size(0, 13);
            this.lblquiz1.TabIndex = 18;
            this.lblquiz1.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::seaQuizes.Properties.Resources.croc;
            this.pictureBox3.Location = new System.Drawing.Point(491, 155);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::seaQuizes.Properties.Resources.fish2;
            this.pictureBox2.Location = new System.Drawing.Point(491, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::seaQuizes.Properties.Resources.fsh1;
            this.pictureBox1.Location = new System.Drawing.Point(491, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Answer the followings reptile questions";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.option1DataGridViewTextBoxColumn,
            this.option2DataGridViewTextBoxColumn,
            this.option3DataGridViewTextBoxColumn,
            this.option4DataGridViewTextBoxColumn,
            this.correctAnswerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reptilestblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 127);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(13, 198);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(0, 13);
            this.lblScores.TabIndex = 32;
            // 
            // quizgameDataSet7
            // 
            this.quizgameDataSet7.DataSetName = "quizgameDataSet7";
            this.quizgameDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reptilestblBindingSource
            // 
            this.reptilestblBindingSource.DataMember = "Reptilestbl";
            this.reptilestblBindingSource.DataSource = this.quizgameDataSet7;
            // 
            // reptilestblTableAdapter
            // 
            this.reptilestblTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // option1DataGridViewTextBoxColumn
            // 
            this.option1DataGridViewTextBoxColumn.DataPropertyName = "Option1";
            this.option1DataGridViewTextBoxColumn.HeaderText = "Option1";
            this.option1DataGridViewTextBoxColumn.Name = "option1DataGridViewTextBoxColumn";
            this.option1DataGridViewTextBoxColumn.Visible = false;
            // 
            // option2DataGridViewTextBoxColumn
            // 
            this.option2DataGridViewTextBoxColumn.DataPropertyName = "Option2";
            this.option2DataGridViewTextBoxColumn.HeaderText = "Option2";
            this.option2DataGridViewTextBoxColumn.Name = "option2DataGridViewTextBoxColumn";
            this.option2DataGridViewTextBoxColumn.Visible = false;
            // 
            // option3DataGridViewTextBoxColumn
            // 
            this.option3DataGridViewTextBoxColumn.DataPropertyName = "Option3";
            this.option3DataGridViewTextBoxColumn.HeaderText = "Option3";
            this.option3DataGridViewTextBoxColumn.Name = "option3DataGridViewTextBoxColumn";
            this.option3DataGridViewTextBoxColumn.Visible = false;
            // 
            // option4DataGridViewTextBoxColumn
            // 
            this.option4DataGridViewTextBoxColumn.DataPropertyName = "Option4";
            this.option4DataGridViewTextBoxColumn.HeaderText = "Option4";
            this.option4DataGridViewTextBoxColumn.Name = "option4DataGridViewTextBoxColumn";
            this.option4DataGridViewTextBoxColumn.Visible = false;
            // 
            // correctAnswerDataGridViewTextBoxColumn
            // 
            this.correctAnswerDataGridViewTextBoxColumn.DataPropertyName = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.HeaderText = "CorrectAnswer";
            this.correctAnswerDataGridViewTextBoxColumn.Name = "correctAnswerDataGridViewTextBoxColumn";
            this.correctAnswerDataGridViewTextBoxColumn.Visible = false;
            // 
            // Reptilesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 406);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.showdb);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.startquiz);
            this.Controls.Add(this.lblquiz3);
            this.Controls.Add(this.lblquiz2);
            this.Controls.Add(this.lblquiz1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reptilesfrm";
            this.Text = "Reptiles";
            this.Load += new System.EventHandler(this.Reptilesfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizgameDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reptilestblBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton option4;
        private System.Windows.Forms.RadioButton option3;
        private System.Windows.Forms.RadioButton option2;
        private System.Windows.Forms.RadioButton option1;
        private System.Windows.Forms.Button showdb;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button startquiz;
        private System.Windows.Forms.Label lblquiz3;
        private System.Windows.Forms.Label lblquiz2;
        private System.Windows.Forms.Label lblquiz1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblScores;
        private quizgameDataSet7 quizgameDataSet7;
        private System.Windows.Forms.BindingSource reptilestblBindingSource;
        private quizgameDataSet7TableAdapters.ReptilestblTableAdapter reptilestblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctAnswerDataGridViewTextBoxColumn;
    }
}