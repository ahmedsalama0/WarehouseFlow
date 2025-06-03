namespace WarehouseFlow
{
    partial class formMain
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
            // formMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 453);
            Controls.Add(btnWarehouse);
            Controls.Add(textBoxMain);
            MaximumSize = new Size(1000, 500);
            MinimumSize = new Size(1000, 500);
            Name = "formMain";
            Text = "Form1";
            Resize += formMain_Resize;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMain;
        private Button btnWarehouse;
    }
}
