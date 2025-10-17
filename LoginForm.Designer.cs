namespace Shoppy
{
    partial class LoginForm
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
            UserName = new TextBox();
            Password = new TextBox();
            pictureBox1 = new PictureBox();
            LogIn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UserName
            // 
            UserName.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            UserName.Location = new Point(105, 280);
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Username";
            UserName.Size = new Size(200, 36);
            UserName.TabIndex = 0;
            // 
            // Password
            // 
            Password.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            Password.Location = new Point(105, 397);
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(200, 36);
            Password.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Poster3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 600);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // LogIn
            // 
            LogIn.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            LogIn.Location = new Point(277, 521);
            LogIn.Name = "LogIn";
            LogIn.Size = new Size(121, 46);
            LogIn.TabIndex = 3;
            LogIn.Text = "Log in";
            LogIn.UseVisualStyleBackColor = true;
            LogIn.Click += button1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 595);
            Controls.Add(LogIn);
            Controls.Add(Password);
            Controls.Add(UserName);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private TextBox Password;
        private PictureBox pictureBox1;
        private Button LogIn;
    }
}