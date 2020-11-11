namespace VehicleDatabase
{
    partial class frmMain
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
            this.vehicleDatabaseDataSet = new VehicleDatabase.VehicleDatabaseDataSet();
            this.lblMake = new System.Windows.Forms.Label();
            this.listMake = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleDatabaseDataSet
            // 
            this.vehicleDatabaseDataSet.DataSetName = "VehicleDatabaseDataSet";
            this.vehicleDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(85, 48);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(42, 17);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            this.lblMake.Click += new System.EventHandler(this.label1_Click);
            // 
            // listMake
            // 
            this.listMake.FormattingEnabled = true;
            this.listMake.ItemHeight = 16;
            this.listMake.Location = new System.Drawing.Point(43, 87);
            this.listMake.Name = "listMake";
            this.listMake.Size = new System.Drawing.Size(134, 308);
            this.listMake.TabIndex = 1;
            this.listMake.SelectedIndexChanged += new System.EventHandler(this.listMake_SelectedIndexChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 959);
            this.Controls.Add(this.listMake);
            this.Controls.Add(this.lblMake);
            this.Name = "frmMain";
            this.Text = "VehicleDatabase";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VehicleDatabaseDataSet vehicleDatabaseDataSet;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.ListBox listMake;
    }
}

