namespace Shoppy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            button5 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            imageList1 = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.Silver;
            splitContainer1.Panel1.BackgroundImageLayout = ImageLayout.Stretch;
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(textBox1);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.AutoScroll = true;
            splitContainer1.Panel2.BackColor = SystemColors.ControlDarkDark;
            splitContainer1.Size = new Size(1308, 685);
            splitContainer1.SplitterDistance = 339;
            splitContainer1.TabIndex = 0;
            // 
            // button5
            // 
            button5.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(0, 196);
            button5.Name = "button5";
            button5.Size = new Size(343, 53);
            button5.TabIndex = 5;
            button5.Text = "Submit new item";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(282, 125);
            button2.Name = "button2";
            button2.Size = new Size(55, 53);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.Font = new Font("Rockwell", 20F);
            textBox1.Location = new Point(12, 15);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Search items";
            textBox1.Size = new Size(258, 39);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(3, 125);
            button4.Name = "button4";
            button4.Size = new Size(56, 53);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.SearchIcon;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(286, 15);
            button3.Name = "button3";
            button3.Size = new Size(42, 39);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Rockwell", 20F, FontStyle.Bold);
            button1.Location = new Point(0, 632);
            button1.Name = "button1";
            button1.Size = new Size(343, 53);
            button1.TabIndex = 0;
            button1.Text = "Submit new item";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1308, 685);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Home";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private ImageList imageList1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private TextBox textBox1;
        private Button button5;
    }
}
