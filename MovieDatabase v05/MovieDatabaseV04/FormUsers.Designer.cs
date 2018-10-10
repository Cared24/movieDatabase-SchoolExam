namespace MovieDatabaseV04
{
    partial class FormUsers
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.Location = new System.Drawing.Point(0, 0);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(536, 463);
            this.listViewUsers.TabIndex = 0;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieDatabaseV04.Properties.Resources.Blue_movie_film_strip_backgrounds_1000x7501;
            this.ClientSize = new System.Drawing.Size(589, 527);
            this.Controls.Add(this.listViewUsers);
            this.Name = "FormUsers";
            this.Text = "List of Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsers;
    }
}