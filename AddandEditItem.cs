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
        public int ID;
        SubmittedItem Entry = new SubmittedItem();
        public AddandEditItem(int Id)
        {
            ID = Id;
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
            Button button2 = new Button()
            {
                Location = button1.Location,
                Text = "Confirm Edit",
                Size = button1.Size
            };
            button2.Click += (s, e) =>
            {
                SubmitEntry(item);
                JsonManager.UpdateItemInJson(item);
                MessageBox.Show("Item successfully edited.");
                this.Close();
            };
            this.Controls.Add(button2);

            button1.Visible = false;
        }

        public void SubmitEntry(Item entry)
        {
            entry.name = NameText.Text;
            if (String.IsNullOrWhiteSpace(NameText.Text))
            {
                MessageBox.Show("Please enter a valid name.");
                return;
            }


            if (string.IsNullOrWhiteSpace(PrizeText.Text) || !double.TryParse(PrizeText.Text, out double price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }
            entry.price = price;

            if (string.IsNullOrWhiteSpace(QuantityText.Text) || int.Parse(QuantityText.Text) < 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            if (string.IsNullOrWhiteSpace(CategoryText.Text))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            if (string.IsNullOrWhiteSpace(DescryptionText.Text))
            {
                MessageBox.Show("Please enter a description");
                return;
            }
            entry.quantity = int.Parse(QuantityText.Text);
            entry.category = CategoryText.Text;
            entry.description = DescryptionText.Text;
            if (pictureBox1.Image == null)
            {
                entry.imagePath = "image\\placeholder.jpg";
            }
            this.Close();

        }

        public void ConfirmEntry(SubmittedItem entry, int UserId)
        {
            SetItem newItem = new SetItem(entry.name, entry.price, entry.quantity, entry.category, entry.description, entry.imagePath);
            JsonManager.AddItemtoJson(newItem);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
                SubmitEntry(Entry);
            ConfirmEntry(Entry, ID);
        }

        private void QuantityText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
        }

        private void PrizeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)46)
            {
                e.Handled = true;
            }
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
