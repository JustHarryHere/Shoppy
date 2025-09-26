using System.Windows.Forms;
using Shoppy;

namespace Shoppy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetItem Sybau = new SetItem(
                "Sybau",
                69.42,
                69,
                "Sybau",
                "Sybau",
                @"C:\Users\user\source\repos\Shoppy\image\Sybau.jpg",
                1
            );
            Panel SybauPanel = CreateItemPanel(Sybau);
            SybauPanel.Location = new System.Drawing.Point(10, 10);
            splitContainer1.Panel2.Controls.Add(SybauPanel);

            SetItem DiscoElysium = new SetItem(
                "Disco Elysium the final cut",
                39.99,
                10,
                "Game",
                "Disco Elysium is a 2019 role-playing video game developed and published by ZA/UM.",
                @"C:\Users\user\source\repos\Shoppy\image\DiscoElysium.jpg",
                2
            );

            Panel DEPanel = CreateItemPanel(DiscoElysium);
            DEPanel.Location = new System.Drawing.Point(310, 10);
            splitContainer1.Panel2.Controls.Add(DEPanel);

            SetItem TheBends = new SetItem(
                "The Bends Vinyl",
                34.95,
                7,
                "Music",
                "The Bends by Radiohead now released in vinyl form",
                @"C:\Users\user\source\repos\Shoppy\image\TheBends.jpg",
                3
            );
            Panel TheBendsPanel = CreateItemPanel(TheBends);
            TheBendsPanel.Location = new System.Drawing.Point(610, 10);
            splitContainer1.Panel2.Controls.Add(TheBendsPanel);

            SetItem NintendoSwitch = new SetItem(
                "Nintendo Switch",
                90,
                7,
                "Technology",
                "The best selling game console of all time",
                @"C:\Users\user\source\repos\Shoppy\image\NintendoSwitch.jpg",
                60
            );
            Panel NSPanel = CreateItemPanel(NintendoSwitch);
            NSPanel.Location = new System.Drawing.Point(10, 190);
            splitContainer1.Panel2.Controls.Add(NSPanel);

            SetItem Spam = new SetItem(
                "Spam",
                90,
                7,
                "Food",
                "Spam",
                @"C:\Users\user\source\repos\Shoppy\image\Spam.jpg",
                60
            );
            Panel SpamPanel = CreateItemPanel(Spam);
            SpamPanel.Location = new System.Drawing.Point(310, 190 );
            splitContainer1.Panel2.Controls.Add(SpamPanel);

            SetItem Apple = new SetItem(
                "Apple",
                90,
                7,
                "Food",
                "A freshly picked apple from the Just_Orchard",
                @"C:\Users\user\source\repos\Shoppy\image\Apple.jpg",
                60
            );
            Panel applePanel = CreateItemPanel(Apple);
            applePanel.Location = new System.Drawing.Point(610, 190);
            splitContainer1.Panel2.Controls.Add(applePanel);

            SetItem CannedBeans = new SetItem(
                "Canned Beans",
                4.89,
                7,
                "Food",
                "Classic Heinz beans, perfect part of a perfect british breakfast.",
                @"C:\Users\user\source\repos\Shoppy\image\CannedBeans.jpg",
                1
            );
            Panel CbeansPanel = CreateItemPanel(CannedBeans);
            CbeansPanel.Location = new System.Drawing.Point(610, 370);
            splitContainer1.Panel2.Controls.Add(CbeansPanel);


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //integrate this into see Item in item class
        public Panel CreateItemPanel(Item item)
        {
            Panel panel = new Panel
            {
                Width = 300,
                Height = 180,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Silver
            };

            Label nameLabel = new Label
            {
                Text =  item.name,
                Top = 10,
                Left = 10,
                Width = 130,
                Height = 20,
                AutoSize = false,
                AutoEllipsis = true 
            };
            Label priceLabel = new Label
            {
                Text = $"Price: {item.price:C2}",
                Top = 35,
                Left = 10,
                AutoSize = true
            };
            Label quantityLabel = new Label
            {
                Text = $"Quantity: {item.quantity}",
                Top = 60,
                Left = 10,
                AutoSize = true
            };
            Label categoryLabel = new Label
            {
                Text = $"Category: {item.category}",
                Top = 85,
                Left = 10,
                AutoSize = true
            };
            Label descriptionLabel = new Label
            {
                Text = $"Description: {item.description}",
                Top = 110,
                Left = 10,
                Width = 120,
                Height= 60,
                AutoSize = false,
                AutoEllipsis = true,
            };
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(quantityLabel);
            panel.Controls.Add(categoryLabel);
            panel.Controls.Add(descriptionLabel);

            //getting display image
            if (!string.IsNullOrEmpty(item.imagePath) && System.IO.File.Exists(item.imagePath))
            {
                PictureBox pictureBox = new PictureBox
                {
                    ImageLocation = item.imagePath,
                    Top = 10,
                    Left = 140,
                    Width = 150,
                    Height = 150,
                    SizeMode = PictureBoxSizeMode.Zoom
                };
                panel.Controls.Add(pictureBox);
            }

            return panel;
        }
    }
}
