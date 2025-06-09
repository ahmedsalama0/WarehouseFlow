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


        public void ClearInputs()
        {
            txtItemId.Clear();
            txtPermitDate.Clear();
            txtProdDate.Clear();
            txtQuantity.Clear();
            txtSupplierId.Clear();
            txtWarehouseId.Clear();
            txtShelfLife.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
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
                EntryDate = DateTime.Parse(txtProdDate.Text),
            };

            _context.SuppliedItems.Add(suppliedItems);
            _context.WarehouseItems.Add(storedItems);
            _context.SaveChanges();
            ClearInputs();
            LoadItems();
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int id2 = (int)dataGridView2.CurrentRow.Cells["Id"].Value;
            int itemId = int.Parse(txtItemId.Text);
            DateTime prodDate = DateTime.Parse(txtProdDate.Text);
            int shelfLife = int.Parse(txtShelfLife.Text);
            SuppliedItem si = _context.SuppliedItems.Find(id2);
            WarehouseItem wi = _context.WarehouseItems.Find(itemId, prodDate, shelfLife);

            //Bug:// if the user wanna change one of the composite pk parts it will not execute
            //Soln://make the pk Just an ID
            if (si != null && wi != null)
            {
                //si.PermitId = int.Parse(txtSupplierId.Text);
                si.ItemId = int.Parse(txtItemId.Text);
                si.WarehouseId = int.Parse(txtWarehouseId.Text);
                si.Quantity = int.Parse(txtQuantity.Text);
                si.ProductionDate = DateTime.Parse(txtProdDate.Text);
                si.ShelfLife = int.Parse(txtShelfLife.Text);

                //remove items from warehouse and re-add them (composite PK)
                _context.WarehouseItems.Remove(wi);
                _context.SaveChanges();

                var storedItems = new WarehouseItem
                {
                    ItemId = int.Parse(txtItemId.Text),
                    ProductionDate = DateTime.Parse(txtProdDate.Text),
                    ShelfLife = int.Parse(txtShelfLife.Text),
                    SupplierId = int.Parse(txtSupplierId.Text),
                    WarehouseId = int.Parse(txtWarehouseId.Text),
                    Quantity = int.Parse(txtQuantity.Text),
                };
                _context.WarehouseItems.Add(storedItems);
                _context.SaveChanges();
                ClearInputs();
                LoadItems();
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView2.CurrentRow.Cells["Id"].Value;

            var Res = _context.SuppliedItems.Find(id);

            if (Res != null)
            {
                _context.SuppliedItems.Remove(Res);
                _context.SaveChanges();
                ClearInputs();
                LoadItems();
            }
        }

        private void btnClearItem_Click(object sender, EventArgs e)
        {
            txtItemId.Clear();
            txtProdDate.Clear();
            txtQuantity.Clear();
            txtWarehouseId.Clear();
            txtShelfLife.Clear();
        }
    }
}
