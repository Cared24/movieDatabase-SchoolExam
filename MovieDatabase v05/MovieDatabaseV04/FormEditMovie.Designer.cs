namespace MovieDatabaseV04
{
    partial class FormEditMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxDirector = new System.Windows.Forms.TextBox();
            this.textBoxReleaseDate = new System.Windows.Forms.TextBox();
            this.textBoxImdb = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelMovieId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(108, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(99, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(68, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Director ID:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(54, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Release Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(92, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "IMDB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(69, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(135, 85);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(278, 20);
            this.textBoxTitle.TabIndex = 8;
            // 
            // textBoxDirector
            // 
            this.textBoxDirector.Location = new System.Drawing.Point(135, 117);
            this.textBoxDirector.Name = "textBoxDirector";
            this.textBoxDirector.Size = new System.Drawing.Size(264, 20);
            this.textBoxDirector.TabIndex = 9;
            // 
            // textBoxReleaseDate
            // 
            this.textBoxReleaseDate.Location = new System.Drawing.Point(135, 149);
            this.textBoxReleaseDate.Name = "textBoxReleaseDate";
            this.textBoxReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxReleaseDate.TabIndex = 10;
            // 
            // textBoxImdb
            // 
            this.textBoxImdb.Location = new System.Drawing.Point(135, 185);
            this.textBoxImdb.Name = "textBoxImdb";
            this.textBoxImdb.Size = new System.Drawing.Size(37, 20);
            this.textBoxImdb.TabIndex = 11;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(135, 215);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(278, 136);
            this.textBoxDescription.TabIndex = 12;
            // 
            // labelMovieId
            // 
            this.labelMovieId.AutoSize = true;
            this.labelMovieId.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelMovieId.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMovieId.Location = new System.Drawing.Point(132, 55);
            this.labelMovieId.Name = "labelMovieId";
            this.labelMovieId.Size = new System.Drawing.Size(61, 13);
            this.labelMovieId.TabIndex = 18;
            this.labelMovieId.Text = "_________";
            // 
            // FormEditMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieDatabaseV04.Properties.Resources.Blue_movie_film_strip_backgrounds_1000x7501;
            this.ClientSize = new System.Drawing.Size(605, 451);
            this.Controls.Add(this.labelMovieId);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxImdb);
            this.Controls.Add(this.textBoxReleaseDate);
            this.Controls.Add(this.textBoxDirector);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEditMovie";
            this.Text = "Edit Movie";
            this.Load += new System.EventHandler(this.FormEditMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.TextBox textBoxDirector;
        private System.Windows.Forms.TextBox textBoxReleaseDate;
        private System.Windows.Forms.TextBox textBoxImdb;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelMovieId;
    }
}