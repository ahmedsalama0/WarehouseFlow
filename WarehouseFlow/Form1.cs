namespace WarehouseFlow
{
    public partial class formMain : Form
    {
        entityForm frmWareHouse = new entityForm();
        public formMain()
        {
            InitializeComponent();
            frmWareHouse.FormClosed += (s, e) => this.Visible = true;
        }


        private void formMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmWareHouse.Show();
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
