using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirRogue
{
    public partial class Loot : Form
    {
        Player p = new Player();
       
        public int selectedIndex = 0;

        List<Item> itemsToLoot = new List<Item>();

        public Loot()
        {
            InitializeComponent();
            //get info about items
            //populate list itemsToLoot
            //demo
            itemsToLoot.Add(new Item("name1", "rffect1", "3", 4));
            listBox1.Items.Add(itemsToLoot[0].itemName);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIndex = listBox1.SelectedIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //send item by index
            p.AddItem(itemsToLoot[0]);
            MessageBox.Show(Inventory.instance.inventory[0].itemName);
        }
    }
}
