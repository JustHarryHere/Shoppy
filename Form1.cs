namespace Shopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Item TestBox = new Item("Test", 9.99, 5, "Category", "This is a test item.", "path/to/image.jpg", 1);
            textBox1.KeyDown += textBox1_KeyDown;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Item TestBox = new Item("Test", 9.99, 5, "Category", "This is a test item.", "path/to/image.jpg", 1);
                TestBox.ItemSettupName(textBox1.Text);
                MessageBox.Show("Item name updated to: " + textBox1.Text);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
