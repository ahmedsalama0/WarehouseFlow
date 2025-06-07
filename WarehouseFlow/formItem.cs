using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WarehouseFlow
{
    public partial class formItem : Form
    {
        private AppDbContext _context = new AppDbContext();

        public formItem()
        {
            InitializeComponent();
            LoadItems();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            dataGridView2.SelectionChanged += dataGridView2_SelectionChanged;

        }

        private void LoadItems()
        {
            dataGridView1.DataSource = _context.Items
                .Select(i => new { i.Id, i.Name })
                .ToList();
            //dataGridView2.DataSource = _context.ItemUnits
            //    .Where(i => i.ItemId == (int)dataGridView1.CurrentRow.Cells["Id"].Value)
            //    .Select(i => new { i.ItemId, i.Unit })
            //    .ToList();
            dataGridView1.Columns["Id"].Visible = false;
            //dataGridView2.Columns["ItemId"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            var item = new Item { Name = txtName.Text };
            _context.Items.Add(item);
            _context.SaveChanges();
            LoadItems();
            txtName.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var item = _context.Items.Find(id);
                if (item != null)
                {
                    item.Name = txtName.Text;
                    _context.SaveChanges();
                    LoadItems();
                    txtName.Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var item = _context.Items.Find(id);
                if (item != null)
                {
                    _context.Items.Remove(item);
                    _context.SaveChanges();
                    LoadItems();
                    txtName.Clear();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value?.ToString();
                dataGridView2.DataSource = _context.ItemUnits
                    .Where(i => i.ItemId == (int)dataGridView1.CurrentRow.Cells["Id"].Value)
                    .Select(i => new { i.ItemId, i.Unit }).ToList();
                dataGridView2.Columns["ItemId"].Visible = false;
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                txtUnit.Text = dataGridView2.CurrentRow.Cells["Unit"].Value?.ToString();
            }
        }

        private void formItem_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUnit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var itemunit = new ItemUnit { ItemId = id, Unit = txtUnit.Text };
                _context.ItemUnits.Add(itemunit);
                _context.SaveChanges();
                LoadItems();
                txtUnit.Clear();
            }
        }

        //update item unit
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int id = (int)dataGridView2.CurrentRow.Cells["ItemId"].Value;
                var itemUnit = _context.ItemUnits.Find(id, (string)dataGridView2.CurrentRow.Cells["Unit"].Value);
                if (itemUnit != null)
                {
                    _context.ItemUnits.Remove(itemUnit);
                    _context.SaveChanges();
                    _context.ItemUnits.Add(new ItemUnit { ItemId = id, Unit = txtUnit.Text});
                    _context.SaveChanges();
                    LoadItems();
                    txtUnit.Clear();
                }
            }
        }

        private void btnDeleteUnit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                int id = (int)dataGridView2.CurrentRow.Cells["ItemId"].Value;
                var itemUnit = _context.ItemUnits.Find(id, (string)dataGridView2.CurrentRow.Cells["Unit"].Value);
                if (itemUnit != null)
                {
                    _context.ItemUnits.Remove(itemUnit);
                    _context.SaveChanges();
                    LoadItems();
                    txtUnit.Clear();
                }
            }
        }
    }

}
