namespace WarehouseFlow
{
    partial class formReport
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
            btnHome = new Button();
            btnWarehouse = new Button();
            SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 440);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(94, 29);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnWarehouse
            // 
            btnWarehouse.Location = new Point(207, 38);
            btnWarehouse.Name = "btnWarehouse";
            btnWarehouse.Size = new Size(220, 29);
            btnWarehouse.TabIndex = 1;
            btnWarehouse.Text = "Warehouse Report";
            btnWarehouse.UseVisualStyleBackColor = true;
            btnWarehouse.Click += btnWarehouse_Click;
            // 
            // formReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 490);
            ControlBox = false;
            Controls.Add(btnWarehouse);
            Controls.Add(btnHome);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "formReport";
            Text = "formReport";
            ResumeLayout(false);
        }

        #endregion

        private Button btnHome;
        private Button btnWarehouse;
    }
}