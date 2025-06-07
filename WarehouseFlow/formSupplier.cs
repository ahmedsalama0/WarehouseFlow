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
    public partial class formSupplier : Form
    {
        private readonly AppDbContext _context = new AppDbContext();

        public formSupplier()
        {
            InitializeComponent();
            LoadSuppliers();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void LoadSuppliers()
        {
            dataGridView1.DataSource = _context.Suppliers
                .Select(s => new { s.Id, s.Name, s.Mobile, s.Fax, s.Phone, s.Email, s.Website })
                .ToList();
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var s = new Supplier
            {
                Mobile = txtMobile.Text,
                Fax = txtFax.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Website = txtWebsite.Text,
                Name = txtName.Text
            };
            _context.Suppliers.Add(s);
            _context.SaveChanges();
            LoadSuppliers();
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var s = _context.Suppliers.Find(id);
                if (s != null)
                {
                    s.Mobile = txtMobile.Text;
                    s.Fax = txtFax.Text;
                    s.Phone = txtPhone.Text;
                    s.Email = txtEmail.Text;
                    s.Website = txtWebsite.Text;
                    s.Name = txtName.Text;
                    _context.SaveChanges();
                    LoadSuppliers();
                    Clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                var s = _context.Suppliers.Find(id);
                if (s != null)
                {
                    _context.Suppliers.Remove(s);
                    _context.SaveChanges();
                    LoadSuppliers();
                    Clear();
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtMobile.Text = dataGridView1.CurrentRow.Cells["Mobile"].Value?.ToString();
                txtFax.Text = dataGridView1.CurrentRow.Cells["Fax"].Value?.ToString();
                txtPhone.Text = dataGridView1.CurrentRow.Cells["Phone"].Value?.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells["Email"].Value?.ToString();
                txtWebsite.Text = dataGridView1.CurrentRow.Cells["Website"].Value?.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value?.ToString();
            }
        }

        private void Clear()
        {
            txtMobile.Clear(); txtFax.Clear(); txtPhone.Clear();
            txtEmail.Clear(); txtWebsite.Clear(); txtName.Clear();
        }
    }

}
