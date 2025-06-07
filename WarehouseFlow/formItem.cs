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
        }

        private void LoadItems()
        {
            dataGridView1.DataSource = _context.Items
                .Select(i => new { i.Id, i.Name })
                .ToList();
            dataGridView1.Columns["Id"].Visible = false;
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
            }
        }
    }

}
