namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tst2 = new System.Windows.Forms.Button();
            this.pbTest = new System.Windows.Forms.PictureBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ListOfMovies = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 473);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(276, 571);
            this.btnOk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(150, 44);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tst2
            // 
            this.tst2.Location = new System.Drawing.Point(276, 663);
            this.tst2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tst2.Name = "tst2";
            this.tst2.Size = new System.Drawing.Size(150, 57);
            this.tst2.TabIndex = 3;
            this.tst2.Text = "test2";
            this.tst2.UseVisualStyleBackColor = true;
            // 
            // pbTest
            // 
            this.pbTest.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.pbTest.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbTest.Image = ((System.Drawing.Image)(resources.GetObject("pbTest.Image")));
            this.pbTest.Location = new System.Drawing.Point(1270, 75);
            this.pbTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(146, 217);
            this.pbTest.TabIndex = 4;
            this.pbTest.TabStop = false;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            this.pbTest.DoubleClick += new System.EventHandler(this.pbTest_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(276, 765);
            this.btncancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(150, 44);
            this.btncancel.TabIndex = 5;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(276, 333);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(300, 33);
            this.comboBox1.TabIndex = 6;
            // 
            // ListOfMovies
            // 
            this.ListOfMovies.FormattingEnabled = true;
            this.ListOfMovies.Location = new System.Drawing.Point(753, 242);
            this.ListOfMovies.Name = "ListOfMovies";
            this.ListOfMovies.Size = new System.Drawing.Size(340, 264);
            this.ListOfMovies.TabIndex = 7;
            this.ListOfMovies.SelectedIndexChanged += new System.EventHandler(this.ListOfMovies_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.ListOfMovies);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.tst2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button tst2;
        private System.Windows.Forms.PictureBox pbTest;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckedListBox ListOfMovies;
    }
}

