using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppy
{
    public partial class AddItem : Form
    {
        SubmittedItem Entry = new SubmittedItem();
        public AddItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void SubmitEntry(SubmittedItem entry)
        {
            entry.name = NameText.Text;
            entry.price = double.Parse(PrizeText.Text);
            entry.quantity = int.Parse(QuantityText.Text);
            entry.category = CategoryText.Text;
            entry.description = DescryptionText.Text;
            if (pictureBox1.Image != null)
            {
                entry.imagePath = "@image/placeholder.jpg"; // Placeholder text
            }
            ConfirmEntry(entry);
        }

        public void ConfirmEntry(SubmittedItem entry)
        {
            SetItem newItem = new SetItem(entry.name, entry.price, entry.quantity, entry.category, entry.description, entry.imagePath);
            JsonManager.AddItemtoJson(@"data\items.json", newItem);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            SubmitEntry(Entry);
            this.Close();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an Image";
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Entry.imagePath = openFileDialog.FileName;
                string imagePath = openFileDialog.FileName;
                pictureBox1.Image = new Bitmap(imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void DescryptionText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DescryptionText.Text))
            {
                MessageBox.Show("Please enter a description");
                return;
            }
        }
    }
}
