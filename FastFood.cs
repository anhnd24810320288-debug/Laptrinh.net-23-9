using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FastFood : Form
    {
        Dictionary<string, double> giaMon = new Dictionary<string, double>()
        {
            { "Hamburger", 50 },
            { "Pizza", 120 },
            { "Gà Rán", 35 },
            { "Pepsi", 15 }
        };

        public FastFood()
        {
            InitializeComponent();

            lblTotal.Text = "Tổng tiền: 0k";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                string mon = lstMenu.SelectedItem.ToString();

                lstSelected.Items.Add(mon);

                TinhTongTien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);

                TinhTongTien();
            }
        }

        private void TinhTongTien()
        {
            double tong = 0;

            foreach (var item in lstSelected.Items)
            {
                string mon = item.ToString();

                if (giaMon.ContainsKey(mon))
                {
                    tong += giaMon[mon];
                }
            }

            lblTotal.Text = "Tổng tiền: " + tong + "k";
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
