namespace MDM4
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
            this.Addbtn = new System.Windows.Forms.Button();
            this.movieListBox = new System.Windows.Forms.ListBox();
            this.ReleaseTxt = new System.Windows.Forms.RichTextBox();
            this.MovieTxt = new System.Windows.Forms.RichTextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(194, 355);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(241, 106);
            this.Addbtn.TabIndex = 0;
            this.Addbtn.Text = "Add Movie";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // movieListBox
            // 
            this.movieListBox.FormattingEnabled = true;
            this.movieListBox.ItemHeight = 31;
            this.movieListBox.Location = new System.Drawing.Point(665, 161);
            this.movieListBox.Name = "movieListBox";
            this.movieListBox.Size = new System.Drawing.Size(413, 469);
            this.movieListBox.TabIndex = 2;
            // 
            // ReleaseTxt
            // 
            this.ReleaseTxt.Location = new System.Drawing.Point(147, 218);
            this.ReleaseTxt.Name = "ReleaseTxt";
            this.ReleaseTxt.Size = new System.Drawing.Size(317, 67);
            this.ReleaseTxt.TabIndex = 4;
            this.ReleaseTxt.Text = "";
            // 
            // MovieTxt
            // 
            this.MovieTxt.Location = new System.Drawing.Point(147, 113);
            this.MovieTxt.Name = "MovieTxt";
            this.MovieTxt.Size = new System.Drawing.Size(317, 67);
            this.MovieTxt.TabIndex = 6;
            this.MovieTxt.Text = "";
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(496, 437);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(138, 85);
            this.Deletebtn.TabIndex = 8;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Location = new System.Drawing.Point(496, 554);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(138, 85);
            this.Editbtn.TabIndex = 10;
            this.Editbtn.Text = "Edit";
            this.Editbtn.UseVisualStyleBackColor = true;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Location = new System.Drawing.Point(194, 355);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(241, 106);
            this.Savebtn.TabIndex = 11;
            this.Savebtn.Text = "Save";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1187, 750);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.MovieTxt);
            this.Controls.Add(this.ReleaseTxt);
            this.Controls.Add(this.movieListBox);
            this.Controls.Add(this.Addbtn);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ListBox movieListBox;
        private System.Windows.Forms.RichTextBox ReleaseTxt;
        private System.Windows.Forms.RichTextBox MovieTxt;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Editbtn;
        private System.Windows.Forms.Button Savebtn;
    }
}

