using System.Windows.Forms;
using Shoppy;
using System.Text.Json; 

namespace Shoppy
{
    public partial class Form1 : Form
    {
        AvailableItems items = new AvailableItems();

        Basket basket = new Basket();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<SetItem> Loaded = JsonManager.OpenItemsFromJson(@"data\items.json");
            items.ConvertlisttoAvailableItems(Loaded);

            SetItem Sybau = new SetItem("Sybau", 69.42, 69, "Sybau", "Sybau", @"image\Sybau.jpg");
            items.Add(Sybau); 

            SetItem DiscoElysium = new SetItem(
                "Disco Elysium the final cut",
                39.99,
                10,
                "Game",
                "Disco Elysium is a 2019 role-playing video game developed and published by ZA/UM.",
                @"image\DiscoElysium.jpg"); items.Add(DiscoElysium);

            SetItem HollowKnight = new SetItem(
                "Hollow Knight",
                39.99,
                10,
                "Game",
                "Forge your own path in Hollow Knight! An epic action adventure through a vast ruined kingdom of insects and heroes. Explore twisting caverns, battle tainted creatures and befriend bizarre bugs, all in a classic, hand-drawn 2D style.",
                @"image\HollowKnight.jpg"); items.Add(HollowKnight);

            SetItem MBDTF = new SetItem(
                "My Beautiful Dark Twisted Fantasy",
                39.99,
                10,
                "Music",
                "My Beautiful Dark Twisted Fantasy is the fifth studio album by the American rapper Kanye West. It was released by Def Jam Recordings and Roc-A-Fella Records on November 22, 2010",
                @"image\MBDTF.jpg"); items.Add(MBDTF);

            SetItem GoWR = new SetItem(
                "Disco Elysium the final cut",
                39.99,
                10,
                "Game",
                "Embark on an epic and heartfelt journey as Kratos and Atreus struggle with holding on and letting go. Against a backdrop of Norse Realms torn asunder by the fury of the Aesir, they’ve been trying their utmost to undo the end times. But despite their best efforts, Fimbulwinter presses onward. Witness the changing dynamic of the father-son relationship as they fight for survival; Atreus thirsts for knowledge to help him understand the prophecy of “Loki”, as Kratos struggles to break free of his past and be the father his son needs. See for yourself how fate will force a choice upon them: between their own safety or the safety of the realms. All the while, hostile Asgardian forces assemble.",
                @"image\GoWR.jpg"); items.Add(GoWR);

            SetItem CryVinyl = new SetItem(
                "Cry - Cigarrete After Sex Vinyl",
                39.99,
                10,
                "Music",
                "Cry is the second studio album by American ambient pop band Cigarettes After Sex, released through Partisan Records on October 25, 2019. It was preceded by the single \"Heavenly\".",
                @"image\CryVinyl.jpg"); items.Add(CryVinyl);

            SetItem UNDERTALE = new SetItem(
                "UNDERTALE",
                39.99,
                10,
                "Game",
                "Undertale is a 2015 role-playing video game created by American indie developer Toby Fox. The player controls a child who has fallen into the Underground: a large, secluded region under the surface of the Earth, separated by a magical barrier. The player meets various monsters during the journey back to the surface, some of which may engage in combat. The combat system involves the player navigating through mini-bullet hell attacks by the opponent. They can opt to appease monsters in order to spare them instead of killing them. These choices affect the game, with the dialogue, characters, and story changing based on outcomes.",
                @"image\UNDERTALE.jpg"); items.Add(UNDERTALE);


            SetItem TheBends = new SetItem(
                 "The Bends Vinyl",
                 34.95,
                 7,
                 "Music",
                 "The Bends by Radiohead now released in vinyl form",
                 @"C:\Users\user\source\repos\Shoppy\image\TheBends.jpg"
             ); items.Add(TheBends);

            SetItem NintendoSwitch = new SetItem(
                "Nintendo Switch",
                90,
                7,
                "Technology",
                "The best selling game console of all time",
                @"C:\Users\user\source\repos\Shoppy\image\NintendoSwitch.jpg"
            ); items.Add(NintendoSwitch);

            SetItem StardewValley = new SetItem(
                "Stardew Valley",
                14.99,
                7,
                "Game",
                "Stardew Valley is an indie cozy farming simulator developed by ConcernedApe originally exclusively on PC and have now been released on multiple platforms. The games allow for multiplayer and gets free updates from the dev",
                @"image\StardewValley.jpg"
            ); items.Add(StardewValley);

            SetItem Apple = new SetItem(
                "Apple",
                90,
                7,
                "Food",
                "A freshly picked apple from the Just_Orchard",
                @"C:\Users\user\source\repos\Shoppy\image\Apple.jpg"
            ); items.Add(Apple);

            SetItem CannedBeans = new SetItem(
                "Canned Beans",
                4.89,
                7,
                "Food",
                "Classic Heinz beans, perfect part of a perfect british breakfast.",
                @"C:\Users\user\source\repos\Shoppy\image\CannedBeans.jpg"
            );

            LoadItem(items);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Categorize(string category)
        {
            LoadItem(items.CategoryFilter(category));
        }

        public void Search(string searchTerm)
        {
            LoadItem(items.SearchItems(searchTerm));
        }
        public Panel CreateItemPanel(Item item)
        {

            Panel panel = new Panel
            {
                Width = 300,
                Height = 180,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Silver
            };

            Panel hitbox = new Panel
            {
                Width = 300,
                Height = 180,
                Visible = false
            };

            Label nameLabel = new Label
            {
                Text = item.name,
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
                Location = new Point(10, 85),
                AutoSize = true
            };
            Label descriptionLabel = new Label
            {
                Text = $"Description: {item.description}",
                Location = new Point(10, 110),
                Width = 120,
                Height = 60,
                AutoSize = false,
                AutoEllipsis = true,
            };
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            panel.Controls.Add(quantityLabel);
            panel.Controls.Add(categoryLabel);
            panel.Controls.Add(descriptionLabel);

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

            panel.Click += (sender, e) =>
            {

                ItemWindow(item, this);
            };

            nameLabel.Click += (sender, e) =>
            {
                ItemWindow(item, this);
            };
            priceLabel.Click += (sender, e) =>
            {
                ItemWindow(item, this);
            };
            quantityLabel.Click += (sender, e) =>
            {
                ItemWindow(item, this);
            };
            categoryLabel.Click += (sender, e) =>
            {
                ItemWindow(item, this);
            };
            descriptionLabel.Click += (sender, e) =>
            {
                ItemWindow(item, this);
            };
            pictureBox.Click += (sender, e) =>
            {
                ItemWindow(item, this);
            };


            return panel;
        }

        public void ItemWindow(Item item, Form form)
        {
            Panel itemPanel = Seeitem(item);
            itemPanel.Location = splitContainer1.Location;
            form.Controls.Add(itemPanel);
            itemPanel.BringToFront();
        }
        public void LoadItem(List<Item> items)
        {
            splitContainer1.Panel2.Controls.Clear();
            int X = 10;
            int Y = 10;

            

            foreach (var item in items)
            {
                Panel NewPanel = CreateItemPanel(item);
                NewPanel.Location = new System.Drawing.Point(X, Y);
                splitContainer1.Panel2.Controls.Add(NewPanel);
                if (X < 610)
                {
                    X += 300;
                }
                else
                {
                    Y += 180; X = 10;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddItem ItemAdding = new AddItem();
            ItemAdding.Show();
        }


        public Panel Seeitem(Item item)
        {
            Panel panel = new Panel
            {
                Size = new Size(1308, 685),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Silver
            };

            Label namelabel = new Label
            {
                Text = item.name,
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(670, 10),
                AutoSize = true,
                AutoEllipsis = true
            };

            Label pricelabel = new Label
            {
                Text = $"Price: {item.price:C2}",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(670, 60),
                AutoSize = true,
            };
            Label quantitylabel = new Label
            {
                Text = $"Quantity: {item.quantity}",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(670, 110),
                AutoSize = true
            };
            Label categorylabel = new Label
            {
                Text = $"Category: {item.category}",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(670, 160),
                AutoSize = true
            };
            TextBox descriptiontextbox = new TextBox
            {
                Text = $"Description: {item.description}",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Size = new Size(600, 350),
                ScrollBars = ScrollBars.Both,
                Location = new Point(670, 210),
                ReadOnly = true,
                Multiline = true,

                BackColor = Color.Silver,
                BorderStyle = BorderStyle.None,
            };

            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = item.imagePath,
                Location = new Point(10, 10),
                Width = 650,
                Height = 650,
                SizeMode = PictureBoxSizeMode.Zoom
            };

            Button BuyButton = new Button
            {
                Text = "Add to Basket",
                Location = new Point(1174, 634),
                Size = new Size(113, 39),
            };

            Button Back = new Button
            {
                Text = "Back",
                Location = new Point(1174, 10),
                Size = new Size(113, 39)

            };

            Panel AdjustPanel = new Panel
            {
                Size = new Size(114, 40),
                Location = new Point(1174, 585),
                
                BackColor = Color.Silver
            };

            TextBox AmountBox = new TextBox
            {
                Text = "1",
                Location = new Point(39, 2),
                Font = new Font("Arial", 18, FontStyle.Regular),
                Size = new Size(36, 40),
                TextAlign = HorizontalAlignment.Right
            };

            Button More = new Button
            {
                Text = "+",
                Font = new Font("Arial", 14, FontStyle.Regular),
                Location = new Point(75, 0),
                Size = new Size(39, 39),
            };

            Button Less = new Button
            {
                Text = "-",
                Location = new Point(0, 0),
                Font = new Font("Arial", 14, FontStyle.Regular),
                Size = new Size(39, 39),
            };


            Button Remove = new Button
            {
                Text = "Remove Item",
                Location = new Point(1051, 634),
                Size = new Size(113, 39),
            };

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(namelabel);
            panel.Controls.Add(pricelabel);
            panel.Controls.Add(quantitylabel);
            panel.Controls.Add(categorylabel);
            panel.Controls.Add(descriptiontextbox);


            panel.Controls.Add(BuyButton);
            panel.Controls.Add(Back);
            AdjustPanel.Controls.Add(AmountBox);
            AdjustPanel.Controls.Add(More);
            AdjustPanel.Controls.Add(Less);
            panel.Controls.Add(AdjustPanel);

            BuyButton.Click += (sender, e) =>
            {
                basket.AddItem(item, int.Parse(AmountBox.Text));
                if (basket.GetItems().Contains(item))
                {
                    panel.Controls.Add(Remove);
                }
                else
                {
                    panel.Controls.Add(Remove);
                }
            };

            Remove.Click += (sender, e) =>
            {
                basket.RemoveItem(item);
                MessageBox.Show($"{item.name} removed from basket.");
                panel.Controls.Remove(Remove);
            };

            Back.Click += (sender, e) =>
            {
                this.Controls.Remove(panel);
            };

            More.Click += (sender, e) =>
            {
                AmountBox.Text = (int.Parse(AmountBox.Text) + 1).ToString();
            };

            Less.Click += (sender, e) =>
            {
                if (int.Parse(AmountBox.Text) > 1)
                {
                    AmountBox.Text = (int.Parse(AmountBox.Text) - 1).ToString();

                }
            };

            return panel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Checkout(basket);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search(textBox1.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categorize("Food");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Search(textBox1.Text);
        }

        public Panel CreateItemPanelCO(Item item)
        {

            Panel panel = new Panel
            {
                Width = 1290,
                Height = 200,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Silver
            };

            Label nameLabel = new Label
            {
                Text = item.name,
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(200, 10),
                AutoSize = true,
                AutoEllipsis = true
               
            };
            Label priceLabel = new Label
            {
                Text = $"Price: {item.price:C2}",
                Font = new Font("Arial", 16, FontStyle.Bold),
                Location = new Point(200,50),
                ForeColor = Color.Green,
                AutoSize = true
            };

            Label categoryLabel = new Label
            {
                Text = $"Category: {item.category}",
                Location = new Point(200,60),
                AutoSize = true
            };

            Panel AdjustPanel = new Panel
            {
                Size = new Size(114, 40),
                Location = new Point(1050, 50),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray
            };

            TextBox AmountBox = new TextBox
            {
                Text = $"{item.inbasket}",
                Location = new Point(39, 1),
                Font = new Font("Arial", 18, FontStyle.Regular),
                Size = new Size(36, 40),
                TextAlign = HorizontalAlignment.Right
            };

            Button More = new Button
            {
                Text = "+",
                Font = new Font("Arial", 14, FontStyle.Regular),
                Location = new Point(75, 0),
                Size = new Size(39, 39),
            };

            Button Less = new Button
            {
                Text = "-",
                Location = new Point(0,0),
                Font = new Font("Arial", 14, FontStyle.Regular),
                Size = new Size(39, 39),
            };

            More.Click += (sender, e) =>
            {
                AmountBox.Text = (int.Parse(AmountBox.Text) + 1).ToString();
            };

            Less.Click += (sender, e) =>
            {
                if (int.Parse(AmountBox.Text) > 1)
                {
                    AmountBox.Text = (int.Parse(AmountBox.Text) - 1).ToString();

                }
            };

            Button Remove = new Button
            {
                Text = "Remove Item",
                Location = new Point(1051, 634),
                Size = new Size(113, 39),
            };
            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            AdjustPanel.Controls.Add(AmountBox);
            panel.Controls.Add(categoryLabel);
            AdjustPanel.Controls.Add(More);
            AdjustPanel.Controls.Add(Less);
            panel.Controls.Add(Remove);
            panel.Controls.Add(AdjustPanel);

            PictureBox pictureBox = new PictureBox
            {
                ImageLocation = item.imagePath,
                Location = new Point(10, 10),
                Size = new Size(180, 180),
                SizeMode = PictureBoxSizeMode.Zoom
            };
            panel.Controls.Add(pictureBox);

            return panel;
        }

        public void LoadItemCO(List<Item> items, Panel panel)
        {
            panel.Controls.Clear();
            int Y = 10;
            foreach (var item in items)
            {
                Panel NewPanel = CreateItemPanelCO(item);
                NewPanel.Location = new System.Drawing.Point(10, Y);
                panel.Controls.Add(NewPanel);
                Y += 200;
            }
        }
        public Panel Checkout(Basket basket)
        {
            Panel Basketpanel = new Panel
            {
                Size = new Size(1308, 685),
                Location = new Point(0, 0),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Silver
            };

            Panel Topanel = new Panel
            {
                Size = new Size(1308, 50),
                Location = new Point(0, 0),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.LightGray
            };
            Button Back = new Button
            {
                Text = "Back",
                Location = new Point(1174, 10),
                Size = new Size(113, 39)
            };

            Back.Click += (sender, e) =>
            {
                this.Controls.Remove(Basketpanel);
            };
            Panel Infopanel = new Panel
            {
                Size = new Size(1308, 585),
                Location = new Point(0, 50),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.Gray,
                AutoScroll = true
            };
            Panel Bottompanel = new Panel
            {
                Size = new Size(1308, 50),
           
                Location = new Point(0, 635),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.DeepSkyBlue,
                AutoScroll = true
            };
            Label TotalLabel = new Label
            {
                Text = $"Total: {basket.GetTotalPrice()} ",
                Font = new Font("Arial", 20, FontStyle.Bold),
                Location = new Point(0, 0),
                AutoSize = true
               
            };
            Topanel.Controls.Add(Back);
            Bottompanel.Controls.Add(TotalLabel);
            Basketpanel.Controls.Add(Topanel);
            Basketpanel.Controls.Add(Infopanel);
            Basketpanel.Controls.Add(Bottompanel);
            
            LoadItemCO(basket.GetItems(), Infopanel);

            return Basketpanel;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Panel checkout = Checkout(basket);
            this.Controls.Add(checkout);
            checkout.BringToFront();
        }
    }

}
