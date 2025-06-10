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
    public partial class formSupplyPermit : Form
    {
        private AppDbContext _context = new AppDbContext();
        public formSupplyPermit()
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
            dataGridView1.DataSource = _context.SupplyPermits.Select(P =>
            new
            {
                P.Id,
                P.SupplierId,
                P.PermitDate
            }).ToList();

            //dataGridView1.Columns["Id"].Visible = false;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var supplyPermit = new SupplyPermit
            {
                SupplierId = int.Parse(txtSupplierId.Text),
                PermitDate = DateTime.Parse(txtPermitDate.Text)
            };

            _context.SupplyPermits.Add(supplyPermit);

            _context.SaveChanges();
            ClearInputs();
            LoadItems();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                SupplyPermit supplyPermit = _context.SupplyPermits.Find(id);
                if (supplyPermit != null)
                {
                    supplyPermit.SupplierId = int.Parse(txtSupplierId.Text);
                    supplyPermit.PermitDate = DateTime.Parse(txtPermitDate.Text);

                    _context.SaveChanges();
                    LoadItems();
                    ClearInputs();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                ClearInputs();
                txtSupplierId.Text = dataGridView1.CurrentRow.Cells["SupplierId"].Value?.ToString();
                txtPermitDate.Text = dataGridView1.CurrentRow.Cells["PermitDate"].Value?.ToString();


                dataGridView2.DataSource = _context.SuppliedItems
                    .Where(P => P.PermitId == (int)dataGridView1.CurrentRow.Cells["Id"].Value)
                    .Select(P => new
                    {
                        P.Id,
                        P.PermitId,
                        P.ItemId,
                        P.WarehouseId,
                        P.Quantity,
                        P.ProductionDate,
                        P.ShelfLife
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
                txtProdDate.Text = dataGridView2.CurrentRow.Cells["ProductionDate"].Value?.ToString();
                txtShelfLife.Text = dataGridView2.CurrentRow.Cells["ShelfLife"].Value?.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                //SupplyPermit result = _context.SupplyPermits.Find(id);
                var result = _context.SupplyPermits.Find(id);
                if (result != null)
                {
                    _context.SupplyPermits.Remove(result);
                    _context.SaveChanges();
                    LoadItems();
                    ClearInputs();
                }
            }
        }

        private void txtPermitDate_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {

            var suppliedItems = new SuppliedItem
            {
                PermitId = (int)dataGridView1.CurrentRow.Cells["Id"].Value,
                ItemId = int.Parse(txtItemId.Text),
                WarehouseId = int.Parse(txtWarehouseId.Text),
                Quantity = int.Parse(txtQuantity.Text),
                ProductionDate = DateTime.Parse(txtProdDate.Text),
                ShelfLife = int.Parse(txtShelfLife.Text)
            };


            var storedItems = new WarehouseItem
            {
                ItemId = int.Parse(txtItemId.Text),
                ProductionDate = DateTime.Parse(txtProdDate.Text),
                ShelfLife = int.Parse(txtShelfLife.Text),
                SupplierId = int.Parse(txtSupplierId.Text),
                WarehouseId = int.Parse(txtWarehouseId.Text),
                Quantity = int.Parse(txtQuantity.Text),
                EntryDate = DateTime.Parse(txtEntryDate.Text),

            };

            var id = _context.WarehouseItems
                .Where(P => P.ItemId == storedItems.ItemId /*&& P.Quantity == storedItems.Quantity*/)
                .Where(P => P.ProductionDate == storedItems.ProductionDate && P.ShelfLife == storedItems.ShelfLife)
                .Where(P => P.SupplierId == storedItems.SupplierId && P.WarehouseId == storedItems.WarehouseId)
                .Where(P => P.EntryDate == storedItems.EntryDate)
                .Select(P => P.Id)
                .FirstOrDefault();
            //MessageBox.Show(id.ToString());

            _context.SuppliedItems.Add(suppliedItems);
            
            if(id == 0)
            {
            _context.WarehouseItems.Add(storedItems);
            }
            else
            {
                WarehouseItem item = _context.WarehouseItems.Find(id);
                if(item != null)
                {
                   //MessageBox.Show(item.Quantity.ToString(), storedItems.Quantity.ToString());
                   item.Quantity += storedItems.Quantity;
                }

            }

            _context.SaveChanges();
            ClearInputs();
            LoadItems();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["Id"].Value;
            
            SuppliedItem si = _context.SuppliedItems.Find(id);
            

            //WarehouseItem wi_id = _context.WarehouseItems.Where();
            //Bug:// if the user wanna change one of the composite pk parts it will not execute
            //SOLVED
          
            if (si != null )
            {
                //find the corresponding warehouse item

                var warehouse_item_id = _context.WarehouseItems
                .Where(P => P.ItemId == si.ItemId)
                .Where(P => P.ProductionDate == si.ProductionDate && P.ShelfLife == si.ShelfLife)
                .Where(P => P.SupplierId == int.Parse(txtSupplierId.Text) && P.WarehouseId == si.WarehouseId)
                .Where(P => P.EntryDate == DateTime.Parse(txtEntryDate.Text))
                .Select(P => P.Id)
                .FirstOrDefault();

                if(warehouse_item_id != 0)
                {

                    WarehouseItem wi = _context.WarehouseItems.Find(warehouse_item_id);
                    int oldQty = si.Quantity;
                    int newQty = int.Parse(txtQuantity.Text);


                    //si.PermitId = int.Parse(txtSupplierId.Text);
                    si.ItemId = int.Parse(txtItemId.Text);
                    si.WarehouseId = int.Parse(txtWarehouseId.Text);
                    si.Quantity = int.Parse(txtQuantity.Text);
                    si.ProductionDate = DateTime.Parse(txtProdDate.Text);
                    si.ShelfLife = int.Parse(txtShelfLife.Text);

                    //remove items from warehouse and re-add them (composite PK)
                   // _context.WarehouseItems.Remove(wi);
                    //var storedItems = new WarehouseItem
                    //{
                    //    ItemId = int.Parse(txtItemId.Text),
                    //    ProductionDate = DateTime.Parse(txtProdDate.Text),
                    //    ShelfLife = int.Parse(txtShelfLife.Text),
                    //    SupplierId = int.Parse(txtSupplierId.Text),
                    //    WarehouseId = int.Parse(txtWarehouseId.Text),
                    //    Quantity = int.Parse(txtQuantity.Text),
                    //    EntryDate = DateTime.Parse(txtEntryDate.Text),
                    //};
                    //_context.WarehouseItems.Add(storedItems);

                    //Schema changed...
                    if(wi.Quantity - oldQty + newQty >= 0)
                    {
                        wi.Quantity += -oldQty + newQty;
                        _context.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Operation");
                    }

                    ClearInputs();
                    LoadItems();
                }
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["Id"].Value;

            var si = _context.SuppliedItems.Find(id);
            

            if (si != null )
            {
                var warehouse_item_id = _context.WarehouseItems
                .Where(P => P.ItemId == si.ItemId)
                .Where(P => P.ProductionDate == si.ProductionDate && P.ShelfLife == si.ShelfLife)
                .Where(P => P.SupplierId == int.Parse(txtSupplierId.Text) && P.WarehouseId == si.WarehouseId)
                .Where(P => P.EntryDate == DateTime.Parse(txtEntryDate.Text))
                .Select(P => P.Id)
                .FirstOrDefault();

                WarehouseItem wi = _context.WarehouseItems.Find(warehouse_item_id);
                int OldQty = si.Quantity;

                if(wi != null)
                {
                    if(wi.Quantity < OldQty)
                    {
                        MessageBox.Show("Invalid Operation!");
                    } else
                    {
                        if (wi.Quantity > OldQty)
                            wi.Quantity -= OldQty;
                        else if (wi.Quantity == OldQty)
                            _context.WarehouseItems.Remove(wi);

                        _context.SuppliedItems.Remove(si);
                        _context.SaveChanges();
                        ClearInputs();
                        LoadItems();
                    }
                }
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
            txtProdDate.Clear();
            txtQuantity.Clear();
            txtWarehouseId.Clear();
            txtShelfLife.Clear();
            txtEntryDate.Clear();
        }
    }
}
