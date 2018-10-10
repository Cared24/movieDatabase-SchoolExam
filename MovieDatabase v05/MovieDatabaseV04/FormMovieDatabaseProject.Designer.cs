namespace MovieDatabaseV04
{
    partial class FormMovieDatabaseProject
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMovieDatabaseProject = new System.Windows.Forms.TabControl();
            this.tabPageMovies = new System.Windows.Forms.TabPage();
            this.tabPageUsers = new System.Windows.Forms.TabPage();
            this.tabPageOrders = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlMovieDatabaseProject.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.aboutUsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1167, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // tabControlMovieDatabaseProject
            // 
            this.tabControlMovieDatabaseProject.Controls.Add(this.tabPageMovies);
            this.tabControlMovieDatabaseProject.Controls.Add(this.tabPageUsers);
            this.tabControlMovieDatabaseProject.Controls.Add(this.tabPageOrders);
            this.tabControlMovieDatabaseProject.Location = new System.Drawing.Point(0, 27);
            this.tabControlMovieDatabaseProject.Name = "tabControlMovieDatabaseProject";
            this.tabControlMovieDatabaseProject.SelectedIndex = 0;
            this.tabControlMovieDatabaseProject.Size = new System.Drawing.Size(1168, 620);
            this.tabControlMovieDatabaseProject.TabIndex = 1;
            // 
            // tabPageMovies
            // 
            this.tabPageMovies.Location = new System.Drawing.Point(4, 22);
            this.tabPageMovies.Name = "tabPageMovies";
            this.tabPageMovies.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovies.Size = new System.Drawing.Size(1160, 594);
            this.tabPageMovies.TabIndex = 0;
            this.tabPageMovies.Text = "Movies";
            this.tabPageMovies.UseVisualStyleBackColor = true;
            // 
            // tabPageUsers
            // 
            this.tabPageUsers.Location = new System.Drawing.Point(4, 22);
            this.tabPageUsers.Name = "tabPageUsers";
            this.tabPageUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUsers.Size = new System.Drawing.Size(1160, 594);
            this.tabPageUsers.TabIndex = 1;
            this.tabPageUsers.Text = "Users";
            this.tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // tabPageOrders
            // 
            this.tabPageOrders.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrders.Name = "tabPageOrders";
            this.tabPageOrders.Size = new System.Drawing.Size(1160, 594);
            this.tabPageOrders.TabIndex = 2;
            this.tabPageOrders.Text = "Orders";
            this.tabPageOrders.UseVisualStyleBackColor = true;
            // 
            // FormMovieDatabaseProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieDatabaseV04.Properties.Resources.Blue_movie_film_strip_backgrounds_1000x750;
            this.ClientSize = new System.Drawing.Size(1167, 646);
            this.Controls.Add(this.tabControlMovieDatabaseProject);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMovieDatabaseProject";
            this.Text = "Movie Database";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMovieDatabaseProject.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMovieDatabaseProject;
        private System.Windows.Forms.TabPage tabPageMovies;
        private System.Windows.Forms.TabPage tabPageUsers;
        private System.Windows.Forms.TabPage tabPageOrders;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

