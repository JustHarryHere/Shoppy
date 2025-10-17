using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoppy
{
    public class SubmittedItem : Item
    {
        public SubmittedItem() { }

        public void ItemSettup(string name, double price, int quantity, string descryption)
        {
            this.name = name;
            this.id += 1;
            this.price = price;
            this.quantity = quantity;
            this.description = descryption;

        }
        public void SubmitItem()
        {
            if (this.name != null && this.price > 0 && this.quantity > 0)
            {
                SetItem USI = new SetItem(this.name, this.price, this.quantity, this.category, this.description, this.imagePath);
                JsonManager.AddItemtoJson(USI);
            }
            else
            {
                MessageBox.Show("Please make sure all fields are entered to submit item");
            }
        }
        public override void EditItem()
        {
            

            // code to display item details
        }
    }
}