namespace WarehouseFlow
{
    partial class WarehouseReport
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
            textBox1 = new TextBox();
            txtWarehouseId = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            labelResults = new Label();
            labelNumOfItems = new Label();
            txtNumOfItems = new TextBox();
            labelNumOfSppliers = new Label();
            txtNumberOfSuppliers = new TextBox();
            labelShelfLife = new Label();
            txtShelfLife = new TextBox();
            labelQuantity = new Label();
            txtQuantity = new TextBox();
            btnSearch = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(34, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(294, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "Enter Warehouse Number to Show Report:";
            // 
            // txtWarehouseId
            // 
            txtWarehouseId.Location = new Point(367, 12);
            txtWarehouseId.Name = "txtWarehouseId";
            txtWarehouseId.Size = new Size(125, 27);
            txtWarehouseId.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(24, 83);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(316, 83);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 3;
            dateTimePicker2.Value = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 60);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "From:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 60);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 5;
            label2.Text = "To:";
            label2.Click += label2_Click;
            // 
            // labelResults
            // 
            labelResults.AutoSize = true;
            labelResults.Location = new Point(24, 144);
            labelResults.Name = "labelResults";
            labelResults.Size = new Size(58, 20);
            labelResults.TabIndex = 6;
            labelResults.Text = "Results:";
            // 
            // labelNumOfItems
            // 
            labelNumOfItems.AutoSize = true;
            labelNumOfItems.Location = new Point(24, 180);
            labelNumOfItems.Name = "labelNumOfItems";
            labelNumOfItems.Size = new Size(128, 20);
            labelNumOfItems.TabIndex = 7;
            labelNumOfItems.Text = "Number of Items: ";
            // 
            // txtNumOfItems
            // 
            txtNumOfItems.Location = new Point(238, 173);
            txtNumOfItems.Name = "txtNumOfItems";
            txtNumOfItems.ReadOnly = true;
            txtNumOfItems.Size = new Size(202, 27);
            txtNumOfItems.TabIndex = 8;
            txtNumOfItems.TextChanged += txtNumOfItems_TextChanged;
            // 
            // labelNumOfSppliers
            // 
            labelNumOfSppliers.AutoSize = true;
            labelNumOfSppliers.Location = new Point(24, 233);
            labelNumOfSppliers.Name = "labelNumOfSppliers";
            labelNumOfSppliers.Size = new Size(153, 20);
            labelNumOfSppliers.TabIndex = 9;
            labelNumOfSppliers.Text = "Number of Suppliers: ";
            // 
            // txtNumberOfSuppliers
            // 
            txtNumberOfSuppliers.Location = new Point(238, 230);
            txtNumberOfSuppliers.Name = "txtNumberOfSuppliers";
            txtNumberOfSuppliers.ReadOnly = true;
            txtNumberOfSuppliers.Size = new Size(202, 27);
            txtNumberOfSuppliers.TabIndex = 11;
            // 
            // labelShelfLife
            // 
            labelShelfLife.AutoSize = true;
            labelShelfLife.Location = new Point(24, 279);
            labelShelfLife.Name = "labelShelfLife";
            labelShelfLife.Size = new Size(180, 20);
            labelShelfLife.TabIndex = 12;
            labelShelfLife.Text = "Shelf Life (Min, Max, Avg):";
            // 
            // txtShelfLife
            // 
            txtShelfLife.Location = new Point(238, 279);
            txtShelfLife.Name = "txtShelfLife";
            txtShelfLife.ReadOnly = true;
            txtShelfLife.Size = new Size(202, 27);
            txtShelfLife.TabIndex = 13;
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(24, 327);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(175, 20);
            labelQuantity.TabIndex = 14;
            labelQuantity.Text = "Quantity (Min, Max, Avg):";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(238, 327);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.ReadOnly = true;
            txtQuantity.Size = new Size(202, 27);
            txtQuantity.TabIndex = 15;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(633, 83);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 409);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 17;
            btnBack.Text = "back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // WarehouseReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnBack);
            Controls.Add(btnSearch);
            Controls.Add(txtQuantity);
            Controls.Add(labelQuantity);
            Controls.Add(txtShelfLife);
            Controls.Add(labelShelfLife);
            Controls.Add(txtNumberOfSuppliers);
            Controls.Add(labelNumOfSppliers);
            Controls.Add(txtNumOfItems);
            Controls.Add(labelNumOfItems);
            Controls.Add(labelResults);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtWarehouseId);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "WarehouseReport";
            Text = "WarehouseReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox txtWarehouseId;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private Label label2;
        private Label labelResults;
        private Label labelNumOfItems;
        private TextBox txtNumOfItems;
        private Label labelNumOfSppliers;
        private TextBox txtNumberOfSuppliers;
        private Label labelShelfLife;
        private TextBox txtShelfLife;
        private Label labelQuantity;
        private TextBox txtQuantity;
        private Button btnSearch;
        private Button btnBack;
    }
}