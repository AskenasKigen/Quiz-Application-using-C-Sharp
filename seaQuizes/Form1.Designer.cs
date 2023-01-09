
namespace seaQuizes
{
    partial class Form1
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
            this.pnlQuiz = new System.Windows.Forms.Panel();
            this.btnRandomquizes = new System.Windows.Forms.Button();
            this.BtnSeaMammals = new System.Windows.Forms.Button();
            this.BtnAmphibians = new System.Windows.Forms.Button();
            this.BtnReptiles = new System.Windows.Forms.Button();
            this.BtnFish = new System.Windows.Forms.Button();
            this.BtnChooseCategory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblname = new System.Windows.Forms.Label();
            this.pnlPages = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Scores = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbltimeup = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQuiz.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlPages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuiz
            // 
            this.pnlQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(29)))));
            this.pnlQuiz.Controls.Add(this.btnRandomquizes);
            this.pnlQuiz.Controls.Add(this.BtnSeaMammals);
            this.pnlQuiz.Controls.Add(this.BtnAmphibians);
            this.pnlQuiz.Controls.Add(this.BtnReptiles);
            this.pnlQuiz.Controls.Add(this.BtnFish);
            this.pnlQuiz.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlQuiz.Location = new System.Drawing.Point(0, 109);
            this.pnlQuiz.Name = "pnlQuiz";
            this.pnlQuiz.Size = new System.Drawing.Size(193, 194);
            this.pnlQuiz.TabIndex = 2;
            // 
            // btnRandomquizes
            // 
            this.btnRandomquizes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRandomquizes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRandomquizes.FlatAppearance.BorderSize = 0;
            this.btnRandomquizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomquizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomquizes.ForeColor = System.Drawing.Color.White;
            this.btnRandomquizes.Location = new System.Drawing.Point(0, 156);
            this.btnRandomquizes.Name = "btnRandomquizes";
            this.btnRandomquizes.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnRandomquizes.Size = new System.Drawing.Size(193, 32);
            this.btnRandomquizes.TabIndex = 4;
            this.btnRandomquizes.Text = "Random Questions";
            this.btnRandomquizes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRandomquizes.UseVisualStyleBackColor = true;
            this.btnRandomquizes.Click += new System.EventHandler(this.btnRandomquizes_Click);
            // 
            // BtnSeaMammals
            // 
            this.BtnSeaMammals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSeaMammals.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnSeaMammals.FlatAppearance.BorderSize = 0;
            this.BtnSeaMammals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSeaMammals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeaMammals.ForeColor = System.Drawing.Color.White;
            this.BtnSeaMammals.Location = new System.Drawing.Point(0, 117);
            this.BtnSeaMammals.Name = "BtnSeaMammals";
            this.BtnSeaMammals.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnSeaMammals.Size = new System.Drawing.Size(193, 39);
            this.BtnSeaMammals.TabIndex = 3;
            this.BtnSeaMammals.Text = "Ask Questions";
            this.BtnSeaMammals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSeaMammals.UseVisualStyleBackColor = true;
            this.BtnSeaMammals.Click += new System.EventHandler(this.BQuestions);
            // 
            // BtnAmphibians
            // 
            this.BtnAmphibians.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAmphibians.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAmphibians.FlatAppearance.BorderSize = 0;
            this.BtnAmphibians.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAmphibians.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAmphibians.ForeColor = System.Drawing.Color.White;
            this.BtnAmphibians.Location = new System.Drawing.Point(0, 78);
            this.BtnAmphibians.Name = "BtnAmphibians";
            this.BtnAmphibians.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnAmphibians.Size = new System.Drawing.Size(193, 39);
            this.BtnAmphibians.TabIndex = 2;
            this.BtnAmphibians.Text = "Birds";
            this.BtnAmphibians.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAmphibians.UseVisualStyleBackColor = true;
            this.BtnAmphibians.Click += new System.EventHandler(this.BtnBirds);
            // 
            // BtnReptiles
            // 
            this.BtnReptiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReptiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnReptiles.FlatAppearance.BorderSize = 0;
            this.BtnReptiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReptiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReptiles.ForeColor = System.Drawing.Color.White;
            this.BtnReptiles.Location = new System.Drawing.Point(0, 39);
            this.BtnReptiles.Name = "BtnReptiles";
            this.BtnReptiles.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnReptiles.Size = new System.Drawing.Size(193, 39);
            this.BtnReptiles.TabIndex = 1;
            this.BtnReptiles.Text = "Reptiles";
            this.BtnReptiles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReptiles.UseVisualStyleBackColor = true;
            this.BtnReptiles.Click += new System.EventHandler(this.BtnReptiles_Click);
            // 
            // BtnFish
            // 
            this.BtnFish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnFish.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnFish.FlatAppearance.BorderSize = 0;
            this.BtnFish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFish.ForeColor = System.Drawing.Color.White;
            this.BtnFish.Location = new System.Drawing.Point(0, 0);
            this.BtnFish.Name = "BtnFish";
            this.BtnFish.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.BtnFish.Size = new System.Drawing.Size(193, 39);
            this.BtnFish.TabIndex = 0;
            this.BtnFish.Text = "Fish";
            this.BtnFish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFish.UseVisualStyleBackColor = true;
            this.BtnFish.Click += new System.EventHandler(this.BtnFish_Click);
            // 
            // BtnChooseCategory
            // 
            this.BtnChooseCategory.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnChooseCategory.FlatAppearance.BorderSize = 0;
            this.BtnChooseCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChooseCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChooseCategory.ForeColor = System.Drawing.Color.White;
            this.BtnChooseCategory.Location = new System.Drawing.Point(0, 75);
            this.BtnChooseCategory.Name = "BtnChooseCategory";
            this.BtnChooseCategory.Size = new System.Drawing.Size(193, 34);
            this.BtnChooseCategory.TabIndex = 1;
            this.BtnChooseCategory.Text = "Choose Category";
            this.BtnChooseCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnChooseCategory.UseVisualStyleBackColor = true;
            this.BtnChooseCategory.Click += new System.EventHandler(this.BtnChooseCategory_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblname);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 75);
            this.panel2.TabIndex = 0;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(12, 27);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(0, 18);
            this.lblname.TabIndex = 0;
            // 
            // pnlPages
            // 
            this.pnlPages.Controls.Add(this.pictureBox1);
            this.pnlPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPages.Location = new System.Drawing.Point(193, 0);
            this.pnlPages.Name = "pnlPages";
            this.pnlPages.Size = new System.Drawing.Size(607, 355);
            this.pnlPages.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::seaQuizes.Properties.Resources.sea;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 355);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Scores
            // 
            this.Scores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Scores.FlatAppearance.BorderSize = 0;
            this.Scores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scores.ForeColor = System.Drawing.Color.White;
            this.Scores.Location = new System.Drawing.Point(0, 303);
            this.Scores.Name = "Scores";
            this.Scores.Size = new System.Drawing.Size(193, 34);
            this.Scores.TabIndex = 3;
            this.Scores.Text = "Scores Board";
            this.Scores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Scores.UseVisualStyleBackColor = true;
            this.Scores.Click += new System.EventHandler(this.Scores_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel3.Controls.Add(this.lbltimeup);
            this.panel3.Controls.Add(this.lbltime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(193, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(607, 95);
            this.panel3.TabIndex = 4;
            // 
            // lbltimeup
            // 
            this.lbltimeup.AutoSize = true;
            this.lbltimeup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltimeup.ForeColor = System.Drawing.Color.White;
            this.lbltimeup.Location = new System.Drawing.Point(235, 27);
            this.lbltimeup.Name = "lbltimeup";
            this.lbltimeup.Size = new System.Drawing.Size(113, 20);
            this.lbltimeup.TabIndex = 1;
            this.lbltimeup.Text = "Time is Up!!!!";
            this.lbltimeup.Visible = false;
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.White;
            this.lbltime.Location = new System.Drawing.Point(104, 27);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(84, 16);
            this.lbltime.TabIndex = 0;
            this.lbltime.Text = "00:00:00:00";
            this.lbltime.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panel1.Controls.Add(this.Scores);
            this.panel1.Controls.Add(this.pnlQuiz);
            this.panel1.Controls.Add(this.BtnChooseCategory);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(193, 450);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlPages);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlQuiz.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlPages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlQuiz;
        private System.Windows.Forms.Button btnRandomquizes;
        private System.Windows.Forms.Button BtnSeaMammals;
        private System.Windows.Forms.Button BtnAmphibians;
        private System.Windows.Forms.Button BtnReptiles;
        private System.Windows.Forms.Button BtnFish;
        private System.Windows.Forms.Button BtnChooseCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Panel pnlPages;
        private System.Windows.Forms.Button Scores;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbltimeup;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

