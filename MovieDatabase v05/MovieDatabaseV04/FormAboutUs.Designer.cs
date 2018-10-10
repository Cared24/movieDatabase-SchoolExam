namespace MovieDatabaseV04
{
    partial class FormAboutUs
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 91);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Database™ (Version 5.0.1)\r\nLast Update: 2018.03.24\r\nMade By: Richárd Pónusz" +
    "\r\n\r\n\r\nAll rights reserved\r\n\r\n";
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(455, 328);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(96, 42);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::MovieDatabaseV04.Properties.Resources.Blue_movie_film_strip_backgrounds_1000x7501;
            this.ClientSize = new System.Drawing.Size(996, 609);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "FormAboutUs";
            this.Text = "About Us";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOk;
    }
}