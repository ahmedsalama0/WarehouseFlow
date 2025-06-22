using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseFlow
{
    public partial class WarehouseReport : Form
    {
        private AppDbContext _context = new AppDbContext();
        bool DatePicker1 = false, DatePicker2 = false;
        public WarehouseReport()
        {
            InitializeComponent();
            ChangeVisisbilty(false);
        }

        public void ChangeVisisbilty(bool flag)
        {
            labelResults.Visible = flag;
            labelNumOfItems.Visible = flag;
            labelNumOfSppliers.Visible = flag;
            labelShelfLife.Visible = flag;
            labelQuantity.Visible = flag;

            txtNumOfItems.Visible = flag;
            txtNumberOfSuppliers.Visible = flag;
            txtShelfLife.Visible = flag;
            txtQuantity.Visible = flag;
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.DatePicker1 = true;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            DatePicker2 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNumOfItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string WarehouseIdText = txtWarehouseId.Text;
            if (string.IsNullOrEmpty(WarehouseIdText))
            {
                MessageBox.Show("Empty Fields!");
                return;
            }
            int result = _context.Warehouses
                        .Where(W => W.Id == int.Parse(WarehouseIdText))
                                            .Select(R => R.Id)
                                            .FirstOrDefault();
            
            Warehouse w = _context.Warehouses.Find(result);
            
            //if not found
            if(w == null)
            {
                MessageBox.Show("Warehouse doesn't exist!");
                return;
            }
            else
            {
                var numOfItems = _context.WarehouseItems.Where(W => W.Id == result).GroupBy(W => W.ItemId).Select(w => w.FirstOrDefault()).Count();
                MessageBox.Show(numOfItems.ToString());
               // ChangeVisisbilty(true);
            }
            
        }
    }
}
