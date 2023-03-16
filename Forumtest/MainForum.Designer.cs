namespace Forumtest
{
    partial class MainForum
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
            this.CreatePostButton = new System.Windows.Forms.Button();
            this.PostList = new System.Windows.Forms.ListBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreatePostButton
            // 
            this.CreatePostButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.CreatePostButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreatePostButton.ForeColor = System.Drawing.Color.White;
            this.CreatePostButton.Location = new System.Drawing.Point(12, 161);
            this.CreatePostButton.Name = "CreatePostButton";
            this.CreatePostButton.Size = new System.Drawing.Size(182, 62);
            this.CreatePostButton.TabIndex = 0;
            this.CreatePostButton.Text = "New Post";
            this.CreatePostButton.UseVisualStyleBackColor = false;
            this.CreatePostButton.Click += new System.EventHandler(this.CreatePostButton_Click);
            // 
            // PostList
            // 
            this.PostList.BackColor = System.Drawing.Color.MidnightBlue;
            this.PostList.ForeColor = System.Drawing.SystemColors.Window;
            this.PostList.FormattingEnabled = true;
            this.PostList.ItemHeight = 25;
            this.PostList.Location = new System.Drawing.Point(237, 12);
            this.PostList.Name = "PostList";
            this.PostList.Size = new System.Drawing.Size(678, 554);
            this.PostList.TabIndex = 1;
            // 
            // ComboBox1
            // 
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Comedy",
            "Thriller",
            "C# documentaries"});
            this.ComboBox1.Location = new System.Drawing.Point(12, 99);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(182, 33);
            this.ComboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Genre:";
            // 
            // MainForum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(956, 590);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.PostList);
            this.Controls.Add(this.CreatePostButton);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForum";
            this.Text = "MainForum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePostButton;
        private System.Windows.Forms.ListBox PostList;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Label label1;
    }
}