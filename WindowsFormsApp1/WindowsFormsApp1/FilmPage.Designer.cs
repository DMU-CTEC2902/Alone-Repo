namespace WindowsFormsApp1
{
    partial class FilmPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmPage));
            this.pbTest = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // pbTest
            // 
            this.pbTest.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pbTest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTest.Image = ((System.Drawing.Image)(resources.GetObject("pbTest.Image")));
            this.pbTest.Location = new System.Drawing.Point(12, 12);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(351, 526);
            this.pbTest.TabIndex = 5;
            this.pbTest.TabStop = false;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            // 
            // FilmPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.pbTest);
            this.Name = "FilmPage";
            this.Text = "NavigationTest";
            this.Load += new System.EventHandler(this.FilmPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbTest;
    }
}