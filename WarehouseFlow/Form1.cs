namespace WarehouseFlow
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void formMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            this.Visible = false;
           // formWarehouse.visi
        }
    }
}
