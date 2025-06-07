namespace WarehouseFlow
{
    partial class formSupplier
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtFax = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtWebsite = new TextBox();
            label6 = new Label();
            txtMobile = new TextBox();
            btnHome = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(328, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(602, 426);
            dataGridView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(21, 280);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(21, 346);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(21, 409);
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
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 91);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 5;
            label2.Text = "fax";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 91);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 174);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(178, 174);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 8;
            label5.Text = "Website";
            // 
            // txtName
            // 
            txtName.Location = new Point(21, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 9;
            // 
            // txtFax
            // 
            txtFax.Location = new Point(178, 114);
            txtFax.Name = "txtFax";
            txtFax.Size = new Size(125, 27);
            txtFax.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(21, 114);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 197);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 12;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(178, 197);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(125, 27);
            txtWebsite.TabIndex = 13;
            txtWebsite.TextChanged += txtWebsite_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 12);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 14;
            label6.Text = "Mobile";
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(178, 35);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(125, 27);
            txtMobile.TabIndex = 15;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(178, 409);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 16;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // formSupplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 450);
            ControlBox = false;
            Controls.Add(btnHome);
            Controls.Add(txtMobile);
            Controls.Add(label6);
            Controls.Add(txtWebsite);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFax);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formSupplier";
            Text = "formSupplier";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtFax;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtWebsite;
        private Label label6;
        private TextBox txtMobile;
        private Button btnHome;
    }
}