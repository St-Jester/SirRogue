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
    public partial class Form1 : Form
    {
        Inventory inv;
        //InventoryPanel.Controls
        public Form1()
        {
            inv = Inventory.instance;
            InitializeComponent();
            inv.onItemChangedCallback += UpdateUI;
        }

        void UpdateUI()
        {
            int length = InventoryPanel.Controls.Count;
            for (int i = 0; i < length; i++)
            {
                if (i < inv.items.Count)  // If there is an item to add
                {
                    MessageBox.Show("Added"+ InventoryPanel.GetControlFromPosition(0,0));
                    //InventoryPanel.Controls.Add()
                    //Add image\icon\button\etc in the table
                }
                else
                {
                    MessageBox.Show("Removed" + InventoryPanel.GetControlFromPosition(0, 0));

                    // Otherwise clear the slot
                    //leave slot empty
                }
            }
        }

        private void InventoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
