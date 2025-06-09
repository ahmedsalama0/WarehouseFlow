namespace WarehouseFlow
{
    partial class FormHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxMain = new TextBox();
            btnWarehouse = new Button();
            btnItem = new Button();
            btnSupplier = new Button();
            btnClient = new Button();
            btnExit = new Button();
            btnSupplyPermit = new Button();
            SuspendLayout();
            // 
            // textBoxMain
            // 
            textBoxMain.CausesValidation = false;
            textBoxMain.Cursor = Cursors.No;
            textBoxMain.Location = new Point(295, 12);
            textBoxMain.Name = "textBoxMain";
            textBoxMain.ReadOnly = true;
            textBoxMain.Size = new Size(411, 27);
            textBoxMain.TabIndex = 1;
            textBoxMain.Text = "Choose an Item to View";
            textBoxMain.TextAlign = HorizontalAlignment.Center;
            textBoxMain.TextChanged += textBoxMain_TextChanged;
            // 
            // btnWarehouse
            // 
            btnWarehouse.Location = new Point(38, 86);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(173, 29);
            btnWarehouse.TabIndex = 1;
            btnWarehouse.Text = "Warehouse";
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // btnItem
            // 
            btnItem.Location = new Point(38, 155);
            btnItem.Name = "btnItem";
            btnItem.Size = new Size(173, 29);
            btnItem.TabIndex = 2;
            btnItem.Text = "Item";
            btnItem.UseVisualStyleBackColor = true;
            btnItem.Click += btnItem_Click;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(38, 224);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(173, 29);
            btnSupplier.TabIndex = 3;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(38, 293);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(173, 29);
            btnClient.TabIndex = 4;
            btnClient.Text = "Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnExit
            // 
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(38, 409);
            btnExit.Margin = new Padding(0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(173, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSupplyPermit
            // 
            btnSupplyPermit.Location = new Point(754, 86);
            btnSupplyPermit.Name = "btnSupplyPermit";
            btnSupplyPermit.Size = new Size(173, 29);
            btnSupplyPermit.TabIndex = 6;
            btnSupplyPermit.Text = "Supply Permit";
            btnSupplyPermit.UseVisualStyleBackColor = true;
            btnSupplyPermit.Click += btnSupplyPermit_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            ControlBox = false;
            Controls.Add(btnSupplyPermit);
            Controls.Add(btnExit);
            Controls.Add(btnClient);
            Controls.Add(btnSupplier);
            Controls.Add(btnItem);
            Controls.Add(btnWarehouse);
            Controls.Add(textBoxMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            Name = "FormHome";
            Text = "Home";
            Resize += formMain_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMain;
        private Button btnWarehouse;
        private Button btnItem;
        private Button btnSupplier;
        private Button btnClient;
        private Button btnExit;
        private Button btnSupplyPermit;
    }
}
