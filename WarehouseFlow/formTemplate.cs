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
    public partial class formTemplate : Form
    {
       
        public formTemplate()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 500;

            optionsBox.DropDownStyle = ComboBoxStyle.DropDownList;
            optionsBox.Items.Add("Add");
            optionsBox.Items.Add("Update");
            optionsBox.Items.Add("Delete");


            //optionsBox.Items.Add("Name");
            //optionsBox.Items.Add("Address");
            //optionsBox.Items.Add("Supervisor");
          
        }

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"{optionsBox.SelectedIndex}");
            int SelectedOption = optionsBox.SelectedIndex;
            switch(SelectedOption)
            {
                //Add
                case 0:
                    break;
                //update
                case 1:
                    break;
                //delete
                case 2:
                    break;
            }
        }
    }
}
