using System.Windows.Forms;

namespace Shopy
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
            textBox1 = new TextBox();
            Enter = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            colorDialog1 = new ColorDialog();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AcceptsReturn = true;
            textBox1.AcceptsTab = true;
            textBox1.AccessibleName = "Input";
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(178, 23);
            textBox1.TabIndex = 0;
            // 
            // Enter
            // 
            Enter.Location = new Point(196, 12);
            Enter.Name = "Enter";
            Enter.Size = new Size(75, 23);
            Enter.TabIndex = 1;
            Enter.Text = "button1";
            Enter.UseVisualStyleBackColor = true;
            Enter.Click += Enter_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Name, Price, Amount });
            dataGridView1.Location = new Point(759, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(395, 618);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // Name
            // 
            Name.HeaderText = "Name";
            Name.Name = "Name";
            // 
            // Price
            // 
            Price.HeaderText = "Price";
            Price.Name = "Price";
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 616);
            Controls.Add(dataGridView1);
            Controls.Add(Enter);
            Controls.Add(textBox1);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Enter;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ColorDialog colorDialog1;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Amount;
    }
}
