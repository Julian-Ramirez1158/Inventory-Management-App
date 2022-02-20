using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFM1_Task1
{
    public partial class AddPart : Form
    {

        public AddPart()
        {

            InitializeComponent();

        }

        



        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddPartSave_Click(object sender, EventArgs e)
        {
            Inventory.AddPart(
                Convert.ToInt32(PartIDBox.Text), 
                NameBox.Text, 
                Convert.ToInt32(InventoryBox.Text), 
                Convert.ToDecimal(PriceBox.Text), 
                Convert.ToInt32(MinBox.Text), 
                Convert.ToInt32(MaxBox.Text)
                );
            this.Hide();
        }
    }
}
