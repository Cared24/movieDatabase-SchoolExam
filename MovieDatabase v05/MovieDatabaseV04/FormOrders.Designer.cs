namespace MovieDatabaseV04
{
    partial class FormOrders
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
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewOrders
            // 
            this.listViewOrders.Location = new System.Drawing.Point(-3, 0);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(612, 444);
            this.listViewOrders.TabIndex = 0;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MovieDatabaseV04.Properties.Resources.Blue_movie_film_strip_backgrounds_1000x750;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.listViewOrders);
            this.Name = "FormOrders";
            this.Text = "List of Orders";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewOrders;
    }
}