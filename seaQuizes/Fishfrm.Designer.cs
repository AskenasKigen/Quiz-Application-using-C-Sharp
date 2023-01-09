
namespace seaQuizes
{
    partial class Fishfrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.option4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correctanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fishtblBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizgameDataSet = new seaQuizes.quizgameDataSet();
            this.SaveAnswers = new System.Windows.Forms.Button();
            this.fishtblTableAdapter = new seaQuizes.quizgameDataSetTableAdapters.FishtblTableAdapter();
            this.lblScores = new System.Windows.Forms.Label();
            this.Option1 = new System.Windows.Forms.RadioButton();
            this.Option2 = new System.Windows.Forms.RadioButton();
            this.Option3 = new System.Windows.Forms.RadioButton();
            this.Option4 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishtblBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizgameDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.questionsDataGridViewTextBoxColumn,
            this.option1DataGridViewTextBoxColumn,
            this.option2DataGridViewTextBoxColumn,
            this.option3DataGridViewTextBoxColumn,
            this.option4DataGridViewTextBoxColumn,
            this.correctanswerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fishtblBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionsDataGridViewTextBoxColumn
            // 
            this.questionsDataGridViewTextBoxColumn.DataPropertyName = "Questions";
            this.questionsDataGridViewTextBoxColumn.HeaderText = "Questions";
            this.questionsDataGridViewTextBoxColumn.Name = "questionsDataGridViewTextBoxColumn";
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
            // correctanswerDataGridViewTextBoxColumn
            // 
            this.correctanswerDataGridViewTextBoxColumn.DataPropertyName = "Correctanswer";
            this.correctanswerDataGridViewTextBoxColumn.HeaderText = "Correctanswer";
            this.correctanswerDataGridViewTextBoxColumn.Name = "correctanswerDataGridViewTextBoxColumn";
            this.correctanswerDataGridViewTextBoxColumn.Visible = false;
            // 
            // fishtblBindingSource
            // 
            this.fishtblBindingSource.DataMember = "Fishtbl";
            this.fishtblBindingSource.DataSource = this.quizgameDataSet;
            // 
            // quizgameDataSet
            // 
            this.quizgameDataSet.DataSetName = "quizgameDataSet";
            this.quizgameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SaveAnswers
            // 
            this.SaveAnswers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SaveAnswers.FlatAppearance.BorderSize = 0;
            this.SaveAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAnswers.ForeColor = System.Drawing.Color.White;
            this.SaveAnswers.Location = new System.Drawing.Point(367, 164);
            this.SaveAnswers.Name = "SaveAnswers";
            this.SaveAnswers.Size = new System.Drawing.Size(138, 38);
            this.SaveAnswers.TabIndex = 9;
            this.SaveAnswers.Text = "Save";
            this.SaveAnswers.UseVisualStyleBackColor = false;
            this.SaveAnswers.Click += new System.EventHandler(this.SaveAnswers_Click);
            // 
            // fishtblTableAdapter
            // 
            this.fishtblTableAdapter.ClearBeforeFill = true;
            // 
            // lblScores
            // 
            this.lblScores.AutoSize = true;
            this.lblScores.Location = new System.Drawing.Point(367, 218);
            this.lblScores.Name = "lblScores";
            this.lblScores.Size = new System.Drawing.Size(0, 13);
            this.lblScores.TabIndex = 10;
            // 
            // Option1
            // 
            this.Option1.AutoSize = true;
            this.Option1.Location = new System.Drawing.Point(23, 175);
            this.Option1.Name = "Option1";
            this.Option1.Size = new System.Drawing.Size(14, 13);
            this.Option1.TabIndex = 11;
            this.Option1.TabStop = true;
            this.Option1.UseVisualStyleBackColor = true;
            this.Option1.CheckedChanged += new System.EventHandler(this.Option1_CheckedChanged);
            // 
            // Option2
            // 
            this.Option2.AutoSize = true;
            this.Option2.Location = new System.Drawing.Point(142, 175);
            this.Option2.Name = "Option2";
            this.Option2.Size = new System.Drawing.Size(14, 13);
            this.Option2.TabIndex = 11;
            this.Option2.TabStop = true;
            this.Option2.UseVisualStyleBackColor = true;
            this.Option2.CheckedChanged += new System.EventHandler(this.Option2_CheckedChanged);
            // 
            // Option3
            // 
            this.Option3.AutoSize = true;
            this.Option3.Location = new System.Drawing.Point(23, 214);
            this.Option3.Name = "Option3";
            this.Option3.Size = new System.Drawing.Size(14, 13);
            this.Option3.TabIndex = 11;
            this.Option3.TabStop = true;
            this.Option3.UseVisualStyleBackColor = true;
            this.Option3.CheckedChanged += new System.EventHandler(this.Option3_CheckedChanged);
            // 
            // Option4
            // 
            this.Option4.AutoSize = true;
            this.Option4.Location = new System.Drawing.Point(142, 214);
            this.Option4.Name = "Option4";
            this.Option4.Size = new System.Drawing.Size(14, 13);
            this.Option4.TabIndex = 11;
            this.Option4.TabStop = true;
            this.Option4.UseVisualStyleBackColor = true;
            this.Option4.CheckedChanged += new System.EventHandler(this.Option4_CheckedChanged);
            // 
            // Fishfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 367);
            this.Controls.Add(this.Option4);
            this.Controls.Add(this.Option3);
            this.Controls.Add(this.Option2);
            this.Controls.Add(this.Option1);
            this.Controls.Add(this.lblScores);
            this.Controls.Add(this.SaveAnswers);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fishfrm";
            this.Text = "Fishfrm";
            this.Load += new System.EventHandler(this.Fishfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fishtblBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizgameDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveAnswers;
        private quizgameDataSet quizgameDataSet;
        private System.Windows.Forms.BindingSource fishtblBindingSource;
        private quizgameDataSetTableAdapters.FishtblTableAdapter fishtblTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn option4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correctanswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblScores;
        private System.Windows.Forms.RadioButton Option1;
        private System.Windows.Forms.RadioButton Option2;
        private System.Windows.Forms.RadioButton Option3;
        private System.Windows.Forms.RadioButton Option4;
    }
}