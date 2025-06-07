namespace WarehouseFlow
{
    partial class formItem
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
            dataGridView1 = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label1 = new Label();
            txtName = new TextBox();
            label2 = new Label();
            txtUnit = new TextBox();
            btnAddUnit = new Button();
            label3 = new Label();
            label4 = new Label();
            dataGridView2 = new DataGridView();
            btnUpdateUnit = new Button();
            btnDeleteUnit = new Button();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(382, 53);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(406, 190);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(42, 137);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(148, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(254, 137);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 53);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 4;
            label1.Text = "Item name";
            // 
            // txtName
            // 
            txtName.Location = new Point(41, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(307, 27);
            txtName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 223);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 6;
            label2.Text = "Item's Unit";
            // 
            // txtUnit
            // 
            txtUnit.Location = new Point(41, 246);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(302, 27);
            txtUnit.TabIndex = 7;
            // 
            // btnAddUnit
            // 
            btnAddUnit.Location = new Point(41, 293);
            btnAddUnit.Name = "btnAddUnit";
            btnAddUnit.Size = new Size(94, 29);
            btnAddUnit.TabIndex = 8;
            btnAddUnit.Text = "Add Unit";
            btnAddUnit.UseVisualStyleBackColor = true;
            btnAddUnit.Click += btnAddUnit_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 30);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 9;
            label3.Text = "Items";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 249);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 10;
            label4.Text = "Item Unit";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(382, 275);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(406, 78);
            dataGridView2.TabIndex = 11;
            // 
            // btnUpdateUnit
            // 
            btnUpdateUnit.Location = new Point(141, 293);
            btnUpdateUnit.Name = "btnUpdateUnit";
            btnUpdateUnit.Size = new Size(101, 29);
            btnUpdateUnit.TabIndex = 12;
            btnUpdateUnit.Text = "Update Unit";
            btnUpdateUnit.UseVisualStyleBackColor = true;
            btnUpdateUnit.Click += button1_Click;
            // 
            // btnDeleteUnit
            // 
            btnDeleteUnit.Location = new Point(248, 293);
            btnDeleteUnit.Name = "btnDeleteUnit";
            btnDeleteUnit.Size = new Size(94, 29);
            btnDeleteUnit.TabIndex = 13;
            btnDeleteUnit.Text = "Delete Unit";
            btnDeleteUnit.UseVisualStyleBackColor = true;
            btnDeleteUnit.Click += btnDeleteUnit_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 339);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 14;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // formItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 380);
            ControlBox = false;
            Controls.Add(btnHome);
            Controls.Add(btnDeleteUnit);
            Controls.Add(btnUpdateUnit);
            Controls.Add(dataGridView2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnAddUnit);
            Controls.Add(txtUnit);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formItem";
            Text = "ItemForm";
            Load += formItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private TextBox txtUnit;
        private Button btnAddUnit;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView2;
        private Button btnUpdateUnit;
        private Button btnDeleteUnit;
        private Button btnHome;
    }
}