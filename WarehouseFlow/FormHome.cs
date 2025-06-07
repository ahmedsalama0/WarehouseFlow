namespace WarehouseFlow
{
    public partial class FormHome : Form
    {

        formWarehouse formWarehouse = new formWarehouse();
         formItem formItem = new formItem();
        formSupplier formSupplier = new formSupplier();
        formClient formClient = new formClient();

        //formTemplate formClient = new formTemplate();
        //formTemplate formSupplyPermit = new formTemplate();
        //formTemplate formReleasePermit = new formTemplate();




        public FormHome()
        {
            InitializeComponent();
            formWarehouse.FormClosed += (s, e) => this.Visible = true;
            formItem.FormClosed += (s, e) => this.Visible = true;
            formSupplier.FormClosed += (s, e) => this.Visible = true;
            formClient.FormClosed += (s, e) => this.Visible = true;
            //formSupplyPermit.FormClosed += (s, e) => this.Visible = true;
            //formReleasePermit.FormClosed += (s, e) => this.Visible = true;

        }


        private void formMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
           
            formWarehouse.Show();
            this.Visible = false;


        }

        private void btnItem_Click(object sender, EventArgs e)
        {

            formItem.Show();
            this.Visible = false;


        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {

            formSupplier.Show();
            this.Visible = false;


        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            formClient.Show();
            this.Visible = false;


        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
