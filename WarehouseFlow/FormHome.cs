namespace WarehouseFlow
{
    public partial class FormHome : Form
    {





        //formTemplate formClient = new formTemplate();
        //formTemplate formSupplyPermit = new formTemplate();
        //formTemplate formReleasePermit = new formTemplate();




        public FormHome()
        {
            InitializeComponent();
            //formWarehouse.FormClosed += (s, e) => this.Visible = true;
            //formItem.FormClosed += (s, e) => this.Visible = true;
            //formSupplier.FormClosed += (s, e) => this.Visible = true;
            //formClient.FormClosed += (s, e) => this.Visible = true;
            //formSupplyPermit.FormClosed += (s, e) => this.Visible = true;
            //formReleasePermit.FormClosed += (s, e) => this.Visible = true;

        }


        private void formMain_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void btnWarehouse_Click(object sender, EventArgs e)
        {
            formWarehouse formWarehouse = new formWarehouse();
            formWarehouse.FormClosed += (s, e) => Show();
            this.Hide();
            formWarehouse.Show();


        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            formItem formItem = new formItem();
            formItem.FormClosed += (s, e) => Visible = true;
            this.Visible = false;
            formItem.Show();


        }
        private void btnSupplier_Click(object sender, EventArgs e)
        {
            formSupplier formSupplier = new formSupplier();
            formSupplier.FormClosed += (s, e) => this.Show();
            this.Hide();
            formSupplier.Show();

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            formClient formClient = new formClient();
            formClient.FormClosed += (s, e) => this.Visible = true;
            this.Visible = false;
            formClient.Show();



        }

        private void textBoxMain_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSupplyPermit_Click(object sender, EventArgs e)
        {
            formSupplyPermit sp = new formSupplyPermit();
            sp.FormClosed += (s, e) => this.Show();
            this.Hide();
            sp.Show();

        }
    }
}
