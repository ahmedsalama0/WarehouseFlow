namespace WarehouseFlow
{
    partial class formTemplate
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
        protected void InitializeComponent()
        {
            dataGridViewWarehouse = new DataGridView();
            optionsBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewWarehouse).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewWarehouse
            // 
            dataGridViewWarehouse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewWarehouse.Location = new Point(360, 12);
            dataGridViewWarehouse.Name = "dataGridViewWarehouse";
            dataGridViewWarehouse.RowHeadersWidth = 51;
            dataGridViewWarehouse.Size = new Size(582, 429);
            dataGridViewWarehouse.TabIndex = 3;
            // 
            // optionsBox
            // 
            optionsBox.FormattingEnabled = true;
            optionsBox.Location = new Point(74, 44);
            optionsBox.Name = "optionsBox";
            optionsBox.Size = new Size(151, 28);
            optionsBox.TabIndex = 4;
            optionsBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 21);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 5;
            label1.Text = " Select an Action:";
            // 
            // formTemplate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(label1);
            Controls.Add(optionsBox);
            Controls.Add(dataGridViewWarehouse);
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            Name = "formTemplate";
            ((System.ComponentModel.ISupportInitialize)dataGridViewWarehouse).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected DataGridView dataGridViewWarehouse;
        protected ComboBox optionsBox;
        protected Label label1;
    }
}