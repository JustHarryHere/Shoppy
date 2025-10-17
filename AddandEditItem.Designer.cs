namespace Shoppy
{
    partial class AddandEditItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddandEditItem));
            NameText = new TextBox();
            button1 = new Button();
            PrizeText = new TextBox();
            DescryptionText = new TextBox();
            QuantityText = new TextBox();
            pictureBox1 = new PictureBox();
            Namelabel = new Label();
            Prizelabel = new Label();
            label3 = new Label();
            label4 = new Label();
            CategoryText = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameText
            // 
            NameText.Location = new Point(41, 79);
            NameText.Name = "NameText";
            NameText.PlaceholderText = "Item name";
            NameText.Size = new Size(257, 23);
            NameText.TabIndex = 0;
            NameText.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(668, 385);
            button1.Name = "button1";
            button1.Size = new Size(96, 41);
            button1.TabIndex = 1;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PrizeText
            // 
            PrizeText.Location = new Point(41, 135);
            PrizeText.Name = "PrizeText";
            PrizeText.PlaceholderText = "00.00$";
            PrizeText.Size = new Size(77, 23);
            PrizeText.TabIndex = 2;
            // 
            // DescryptionText
            // 
            DescryptionText.Location = new Point(41, 261);
            DescryptionText.Multiline = true;
            DescryptionText.Name = "DescryptionText";
            DescryptionText.PlaceholderText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit,";
            DescryptionText.Size = new Size(257, 88);
            DescryptionText.TabIndex = 3;
            DescryptionText.TextChanged += DescryptionText_TextChanged;
            // 
            // QuantityText
            // 
            QuantityText.Location = new Point(41, 196);
            QuantityText.Name = "QuantityText";
            QuantityText.PlaceholderText = "0";
            QuantityText.Size = new Size(257, 23);
            QuantityText.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(464, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Namelabel
            // 
            Namelabel.AutoSize = true;
            Namelabel.Location = new Point(41, 61);
            Namelabel.Name = "Namelabel";
            Namelabel.Size = new Size(39, 15);
            Namelabel.TabIndex = 6;
            Namelabel.Text = "Name";
            // 
            // Prizelabel
            // 
            Prizelabel.AutoSize = true;
            Prizelabel.Location = new Point(41, 117);
            Prizelabel.Name = "Prizelabel";
            Prizelabel.Size = new Size(32, 15);
            Prizelabel.TabIndex = 7;
            Prizelabel.Text = "Prize";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 178);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 8;
            label3.Text = "Currently in stock";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 240);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 9;
            label4.Text = "Descryptiom";
            // 
            // CategoryText
            // 
            CategoryText.Location = new Point(142, 135);
            CategoryText.Name = "CategoryText";
            CategoryText.PlaceholderText = "Miscellaneous";
            CategoryText.Size = new Size(156, 23);
            CategoryText.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(142, 117);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 11;
            label5.Text = "Category";
            // 
            // AddItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(label5);
            Controls.Add(CategoryText);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Prizelabel);
            Controls.Add(Namelabel);
            Controls.Add(pictureBox1);
            Controls.Add(QuantityText);
            Controls.Add(DescryptionText);
            Controls.Add(PrizeText);
            Controls.Add(button1);
            Controls.Add(NameText);
            Name = "AddItem";
            Text = "AddItem";
            Load += AddItem_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameText;
        private Button button1;
        private TextBox PrizeText;
        private TextBox DescryptionText;
        private TextBox QuantityText;
        private PictureBox pictureBox1;
        private Label Namelabel;
        private Label Prizelabel;
        private Label label3;
        private Label label4;
        private TextBox CategoryText;
        private Label label5;
    }
}