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
    public partial class ReleasePermit : Form
    {
        private AppDbContext _context = new AppDbContext();
        public ReleasePermit()
        {
            InitializeComponent();
            LoadItems();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

        }




        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadItems()
        {
            dataGridView1.DataSource = _context.ReleaseOrders.Select(P =>
            new
            {
                P.Id,
                P.SupplierId,
                P.OrderDate
            }).ToList();

            //dataGridView1.Columns["Id"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var releasePermit = new ReleaseOrder
            {
                SupplierId = int.Parse(txtSupplierId.Text),
                OrderDate = DateTime.Parse(txtPermitDate.Text)
            };

            _context.ReleaseOrders.Add(releasePermit);


            _context.SaveChanges();
            ClearInputs();
            LoadItems();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                ReleaseOrder releasePermit = _context.ReleaseOrders.Find(id);
                if (releasePermit != null)
                {
                    releasePermit.SupplierId = int.Parse(txtSupplierId.Text);
                    releasePermit.OrderDate = DateTime.Parse(txtPermitDate.Text);

                    _context.SaveChanges();
                    LoadItems();
                    ClearInputs();
                }
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                //SupplyPermit result = _context.SupplyPermits.Find(id);
                var result = _context.ReleaseOrders.Find(id);
                if (result != null)
                {
                    _context.ReleaseOrders.Remove(result);
                    _context.SaveChanges();
                    LoadItems();
                    ClearInputs();
                }
            }
        }



        private void btnAddItem_Click(object sender, EventArgs e)
        {

            var releasedItems = new ReleasedItem
            {
                PermitId = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                ItemId = int.Parse(txtItemId.Text),
                WarehouseId = int.Parse(txtWarehouseId.Text),
                Quantity = int.Parse(txtQuantity.Text),
            };


            var storedItems = new WarehouseItem
            {
                ItemId = int.Parse(txtItemId.Text),
                SupplierId = int.Parse(txtSupplierId.Text),
                WarehouseId = int.Parse(txtWarehouseId.Text),
                Quantity = int.Parse(txtQuantity.Text),

            };

            var id = _context.WarehouseItems
                .Where(P => P.ItemId == storedItems.ItemId)
                .Where(P => P.SupplierId == storedItems.SupplierId && P.WarehouseId == storedItems.WarehouseId)
                .Where(P => P.Quantity >= releasedItems.Quantity)
                .Select(P => P.Id)
                .FirstOrDefault();


            if (id != 0)
            {
                WarehouseItem item = _context.WarehouseItems.Find(id);
                if (item != null && item.Quantity >= releasedItems.Quantity)
                {
                    if (item.Quantity == releasedItems.Quantity) //qty == 0 => remove it
                        _context.WarehouseItems.Remove(item);
                    else
                        item.Quantity -= releasedItems.Quantity;

                    _context.ReleasedItems.Add(releasedItems);
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Invalid Operaion!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Operaion!");
            }

            ClearInputs();
            LoadItems();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["Id"].Value;

            ReleasedItem si = _context.ReleasedItems.Find(id);

            if (si != null)
            {
                //find the corresponding warehouse item

                var warehouse_item_id = _context.WarehouseItems
                .Where(P => P.ItemId == si.ItemId)
                .Where(P => P.SupplierId == int.Parse(txtSupplierId.Text) && P.WarehouseId == si.WarehouseId)
                .Where(P => P.Quantity >= int.Parse(txtQuantity.Text))
                .Select(P => P.Id)
                .FirstOrDefault();

                if (warehouse_item_id != 0)
                {
                    WarehouseItem wi = _context.WarehouseItems.Find(warehouse_item_id);
                    int oldQty = si.Quantity; //from DB
                    int newQty = int.Parse(txtQuantity.Text); //from UI

                    si.ItemId = int.Parse(txtItemId.Text);
                    si.WarehouseId = int.Parse(txtWarehouseId.Text);
                    si.Quantity = int.Parse(txtQuantity.Text);


                    if (wi != null && wi.Quantity + oldQty - newQty >= 0)
                    {
                        wi.Quantity += oldQty - newQty;

                        //wi.Quantity += oldQty;
                        //wi.Quantity -= newQty;
                        _context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Operation");
                    }

                    ClearInputs();
                    LoadItems();
                }
                else
                {
                    MessageBox.Show("Invalid Operation");
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["Id"].Value;

            var si = _context.ReleasedItems.Find(id);


            if (si != null)
            {
                var warehouse_item_id = _context.WarehouseItems
                .Where(P => P.ItemId == si.ItemId)
                .Where(P => (P.SupplierId == int.Parse(txtSupplierId.Text)) && (P.WarehouseId == si.WarehouseId))
                .Select(P => P.Id)
                .FirstOrDefault();

                WarehouseItem wi = _context.WarehouseItems.Find(warehouse_item_id);
                int OldQty = si.Quantity;

                if (wi != null)
                {
                    wi.Quantity += OldQty;
                    _context.ReleasedItems.Remove(si);

                    _context.SaveChanges();
                    ClearInputs();
                    LoadItems();

                }
                else
                {
                    //if not found it might be moved to another warehouse, so we can create new one in this case
                    MessageBox.Show("Invalid Operation!");
                }
            }
            else
            {
                MessageBox.Show("Invalid Operation!!!");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ClearInputs();
                txtSupplierId.Text = dataGridView1.CurrentRow.Cells["SupplierId"].Value?.ToString();
                txtPermitDate.Text = dataGridView1.CurrentRow.Cells["OrderDate"].Value?.ToString();


                dataGridView2.DataSource = _context.ReleasedItems
                    .Where(P => P.PermitId == (int)dataGridView1.CurrentRow.Cells["Id"].Value)
                    .Select(P => new
                    {
                        P.Id,
                        P.PermitId,
                        P.ItemId,
                        P.WarehouseId,
                        P.Quantity,
                    }).ToList();
                dataGridView2.Columns["Id"].Visible = false;
                dataGridView2.Columns["PermitId"].Visible = false;

            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                ClearItemFields();
                txtItemId.Text = dataGridView2.CurrentRow.Cells["ItemId"].Value?.ToString();
                txtWarehouseId.Text = dataGridView2.CurrentRow.Cells["WarehouseId"].Value?.ToString();
                txtQuantity.Text = dataGridView2.CurrentRow.Cells["Quantity"].Value?.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            ClearItemFields();
        }

        public void ClearInputs()
        {
            txtPermitDate.Clear();
            txtSupplierId.Clear();
            ClearItemFields();
        }

        public void ClearItemFields()
        {
            txtItemId.Clear();
            txtQuantity.Clear();
            txtWarehouseId.Clear();
        }
        private void txtPermitDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}
