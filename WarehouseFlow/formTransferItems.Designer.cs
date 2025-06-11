namespace WarehouseFlow
{
    partial class formTransferItems
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtFromWarehouse = new TextBox();
            txtToWarehouse = new TextBox();
            txtItemId = new TextBox();
            txtQuantity = new TextBox();
            txtProdDate = new TextBox();
            txtSupplierId = new TextBox();
            txtShelfLife = new TextBox();
            btnTransfer = new Button();
            txtHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Transferred Items";
            label1.Click += label1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(525, 341);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 32);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 2;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 82);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 32);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 4;
            label4.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 82);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 5;
            label5.Text = "Item ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 135);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 6;
            label6.Text = "Supplier ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 186);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 7;
            label7.Text = "Shelf Life";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 135);
            label8.Name = "label8";
            label8.Size = new Size(117, 20);
            label8.TabIndex = 8;
            label8.Text = "Production Date";
            // 
            // txtFromWarehouse
            // 
            txtFromWarehouse.Location = new Point(12, 52);
            txtFromWarehouse.Name = "txtFromWarehouse";
            txtFromWarehouse.Size = new Size(125, 27);
            txtFromWarehouse.TabIndex = 9;
            // 
            // txtToWarehouse
            // 
            txtToWarehouse.Location = new Point(178, 52);
            txtToWarehouse.Name = "txtToWarehouse";
            txtToWarehouse.Size = new Size(125, 27);
            txtToWarehouse.TabIndex = 10;
            // 
            // txtItemId
            // 
            txtItemId.Location = new Point(16, 105);
            txtItemId.Name = "txtItemId";
            txtItemId.Size = new Size(125, 27);
            txtItemId.TabIndex = 11;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(178, 105);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 12;
            // 
            // txtProdDate
            // 
            txtProdDate.Location = new Point(178, 158);
            txtProdDate.Name = "txtProdDate";
            txtProdDate.Size = new Size(125, 27);
            txtProdDate.TabIndex = 13;
            // 
            // txtSupplierId
            // 
            txtSupplierId.Location = new Point(16, 156);
            txtSupplierId.Name = "txtSupplierId";
            txtSupplierId.Size = new Size(125, 27);
            txtSupplierId.TabIndex = 14;
            // 
            // txtShelfLife
            // 
            txtShelfLife.Location = new Point(16, 209);
            txtShelfLife.Name = "txtShelfLife";
            txtShelfLife.Size = new Size(125, 27);
            txtShelfLife.TabIndex = 15;
            // 
            // btnTransfer
            // 
            btnTransfer.Location = new Point(20, 262);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.Size = new Size(121, 31);
            btnTransfer.TabIndex = 16;
            btnTransfer.Text = "Transfer Item";
            btnTransfer.UseVisualStyleBackColor = true;
            btnTransfer.Click += btnTransfer_Click;
            // 
            // txtHome
            // 
            txtHome.Location = new Point(20, 316);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(121, 29);
            txtHome.TabIndex = 17;
            txtHome.Text = "Home";
            txtHome.UseVisualStyleBackColor = true;
            txtHome.Click += txtHome_Click;
            // 
            // formTransferItems
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 380);
            ControlBox = false;
            Controls.Add(txtHome);
            Controls.Add(btnTransfer);
            Controls.Add(txtShelfLife);
            Controls.Add(txtSupplierId);
            Controls.Add(txtProdDate);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemId);
            Controls.Add(txtToWarehouse);
            Controls.Add(txtFromWarehouse);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formTransferItems";
            Text = "formTransferItems";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtFromWarehouse;
        private TextBox txtToWarehouse;
        private TextBox txtItemId;
        private TextBox txtQuantity;
        private TextBox txtProdDate;
        private TextBox txtSupplierId;
        private TextBox txtShelfLife;
        private Button btnTransfer;
        private Button txtHome;
    }
}