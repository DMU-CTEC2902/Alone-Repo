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
            ((System.ComponentModel.ISupportInitialize)(this.pbTest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 246);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(138, 297);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // tst2
            // 
            this.tst2.Location = new System.Drawing.Point(145, 348);
            this.tst2.Margin = new System.Windows.Forms.Padding(2);
            this.tst2.Name = "tst2";
            this.tst2.Size = new System.Drawing.Size(68, 24);
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
            this.pbTest.Location = new System.Drawing.Point(635, 39);
            this.pbTest.Name = "pbTest";
            this.pbTest.Size = new System.Drawing.Size(73, 113);
            this.pbTest.TabIndex = 4;
            this.pbTest.TabStop = false;
            this.pbTest.Click += new System.EventHandler(this.pbTest_Click);
            this.pbTest.DoubleClick += new System.EventHandler(this.pbTest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTest);
            this.Controls.Add(this.tst2);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
    }
}

