namespace WarehouseFlow
{
    public partial class FormHome : Form
    {

       

        public FormHome()
        {
            InitializeComponent();
            //frmWareHouse.FormClosed += (s, e) => this.Visible = true;
        }


        private void formMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
