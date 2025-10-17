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
    public partial class AddandEditItem : Form
    {
        bool isEditMode = false;
        bool isAdmin = false;

        SubmittedItem Entry = new SubmittedItem();
        public AddandEditItem()
        {
            InitializeComponent();
        }

        private void AddItem_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void EditEntry(SetItem item)
        {
            isEditMode = true;
            NameText.Text = item.name;
            PrizeText.Text = item.price.ToString();
            QuantityText.Text = item.quantity.ToString();
            CategoryText.Text = item.category;
            DescryptionText.Text = item.description;
            if (item.imagePath != null)
            {
                pictureBox1.Image = new Bitmap(item.imagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        public void SubmitEntry(Item entry)
        {
            entry.name = NameText.Text;
            entry.price = double.Parse(PrizeText.Text);
            entry.quantity = int.Parse(QuantityText.Text);
            entry.category = CategoryText.Text;
            entry.description = DescryptionText.Text;
            if (pictureBox1.Image != null)
            {
                entry.imagePath = "@image/placeholder.jpg";
            }
        }

        public void ConfirmEntry(SubmittedItem entry)
        {
            SetItem newItem = new SetItem(entry.name, entry.price, entry.quantity, entry.category, entry.description, entry.imagePath);
            JsonManager.AddItemtoJson(@"data\items.json", newItem);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (isEditMode == true)
            {
                MessageBox.Show("Editing items is not supported yet.");
                return;
            }
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
