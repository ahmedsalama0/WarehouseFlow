using Microsoft.EntityFrameworkCore;
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
    public partial class formWarehouse : Form
    {
        private AppDbContext _context = new AppDbContext();
        public formWarehouse()
        {
            InitializeComponent();
            LoadWarehouses();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void LoadWarehouses()
        {
            dataGridView1.DataSource = _context.Warehouses
                .Select(w => new
                {
                    w.Id,
                    w.Name,
                    w.Address,
                    w.Supervisor
                })
                .ToList();

            dataGridView1.Columns["Id"].Visible = false; // Hide Id
        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value?.ToString();
                txtAddress.Text = dataGridView1.CurrentRow.Cells["Address"].Value?.ToString();
                txtSupervisor.Text = dataGridView1.CurrentRow.Cells["Supervisor"].Value?.ToString();
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtSupervisor.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var warehouse = new Warehouse
            {
                Name = txtName.Text,
                Address = txtAddress.Text,
                Supervisor = txtSupervisor.Text
            };

            _context.Warehouses.Add(warehouse);
            _context.SaveChanges();
            LoadWarehouses();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var warehouse = _context.Warehouses.Find(id);

                if (warehouse != null)
                {
                    warehouse.Name = txtName.Text;
                    warehouse.Address = txtAddress.Text;
                    warehouse.Supervisor = txtSupervisor.Text;
                    _context.SaveChanges();
                    LoadWarehouses();
                    ClearInputs();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var warehouse = _context.Warehouses.Find(id);
                if (warehouse != null)
                {
                    _context.Warehouses.Remove(warehouse);
                    _context.SaveChanges();
                    LoadWarehouses();
                    ClearInputs();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
