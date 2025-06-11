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
    public partial class formTransferItems : Form
    {
        private AppDbContext _context = new AppDbContext();

        public formTransferItems()
        {
            InitializeComponent();
            LoadItems();
        }

        public void LoadItems()
        {
            dataGridView1.DataSource = _context.TransferredItems.Select(q => 
            new
            {
                q.FromWarehouseId,
                q.ToWarehouse,
                q.ItemId,
                q.Qty,
                q.SupplierId,
                q.ProductionDate,
                q.ShelfLife,
                q.TransferDate
            }).ToList();

        }

        public void ClearFields()
        {
            txtFromWarehouse.Clear();
            txtToWarehouse.Clear();
            txtItemId.Clear();
            txtSupplierId.Clear();
            txtProdDate.Clear();
            txtQuantity.Clear();
            txtShelfLife.Clear();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //Ensure that the item is available in the target warehouse before
            //moving it to the destination warehouse
            int id = _context.WarehouseItems
                    .Where(P => P.WarehouseId == int.Parse(txtFromWarehouse.Text))
                    .Where(P => P.ItemId == int.Parse(txtItemId.Text))
                    .Where(P => P.SupplierId == int.Parse(txtSupplierId.Text))
                    .Where(P => P.Quantity >= int.Parse(txtQuantity.Text))
                    .Where(P => P.ProductionDate == DateTime.Parse(txtProdDate.Text))
                    .Where(P => P.ShelfLife == int.Parse(txtShelfLife.Text))
                    .Select(P => P.Id).FirstOrDefault();

            WarehouseItem FromWareItem = _context.WarehouseItems.Find(id);

            //Ensuring that the destination warehouse exists
            var res = _context.Warehouses.Find(int.Parse(txtToWarehouse.Text));

            if (res == null)
            {
                MessageBox.Show("Destination Warehouse doesn't exist!");
            }
            else if (FromWareItem == null)
            {
                MessageBox.Show("Invalid Data!");
            }
            else
            {
                //if te item with the same characteristics exists in the dest ware,
                //just add the quantity (warehouse items table)
                //else create a new one
                //append the transaction in the transferred items table
                int to_w_i = _context.WarehouseItems
                    .Where(P => P.WarehouseId == int.Parse(txtToWarehouse.Text))
                    .Where(P => P.ItemId == int.Parse(txtItemId.Text))
                    .Where(P => P.SupplierId == int.Parse(txtSupplierId.Text))
                    .Where(P => P.ProductionDate == DateTime.Parse(txtProdDate.Text))
                    .Where(P => P.ShelfLife == int.Parse(txtShelfLife.Text))
                    .Select(P => P.Id).FirstOrDefault();

                var toWareItem = _context.WarehouseItems.Find(to_w_i);
                if (toWareItem != null) //the same item exists in the dest warehouse
                {
                    toWareItem.Quantity += int.Parse(txtQuantity.Text);
                }
                else
                {
                    //not exists, create new one;
                    WarehouseItem NewObj = new WarehouseItem
                    {
                        ItemId = int.Parse(txtItemId.Text),
                        ProductionDate = DateTime.Parse(txtProdDate.Text),
                        ShelfLife = int.Parse(txtShelfLife.Text),
                        WarehouseId = int.Parse(txtToWarehouse.Text),
                        Quantity = int.Parse(txtQuantity.Text),
                        SupplierId = int.Parse(txtSupplierId.Text),
                        EntryDate = DateTime.Today,

                    };
                    _context.WarehouseItems.Add(NewObj);
                }

                //Decrement the qty from target warehouse
                FromWareItem.Quantity -= int.Parse(txtQuantity.Text);
                //In the target warehouse if the left quantity = 0 remove it
                if (FromWareItem.Quantity == 0)
                    _context.WarehouseItems.Remove(FromWareItem);

                //append the transacion in the transferred items table
                TransferredItem ti = new TransferredItem
                {
                    FromWarehouseId = int.Parse(txtFromWarehouse.Text),
                    ToWarehouseId = int.Parse(txtFromWarehouse.Text),
                    ItemId = int.Parse(txtItemId.Text),
                    Qty = int.Parse(txtQuantity.Text),
                    SupplierId = int.Parse(txtSupplierId.Text),
                    ProductionDate = DateTime.Parse(txtProdDate.Text),
                    ShelfLife = int.Parse(txtShelfLife.Text),
                    TransferDate = DateTime.Today

                };
                _context.TransferredItems.Add(ti);

                _context.SaveChanges();

                ClearFields();
                LoadItems();

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
