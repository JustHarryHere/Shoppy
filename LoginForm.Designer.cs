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
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
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
            // textBox1
            // 
            textBox1.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            textBox1.Location = new Point(105, 397);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Password";
            textBox1.Size = new Size(200, 36);
            textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Poster3;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = "image\\\\Poster.jpg";
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 600);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 18F, FontStyle.Bold);
            button1.Location = new Point(277, 537);
            button1.Name = "button1";
            button1.Size = new Size(121, 46);
            button1.TabIndex = 3;
            button1.Text = "Log in";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 595);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(UserName);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UserName;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Button button1;
    }
}