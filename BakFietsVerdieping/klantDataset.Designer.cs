
namespace BakFietsVerdieping
{
    partial class klantDataset
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
            this.components = new System.ComponentModel.Container();
            this.klant1 = new BakFietsVerdieping.klant();
            this.klant1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klantTableAdapter = new BakFietsVerdieping.klantTableAdapters.klantTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.klant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klant1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // klant1
            // 
            this.klant1.DataSetName = "klant";
            this.klant1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // klant1BindingSource
            // 
            this.klant1BindingSource.DataSource = this.klant1;
            this.klant1BindingSource.Position = 0;
            // 
            // klantBindingSource
            // 
            this.klantBindingSource.DataMember = "klant";
            this.klantBindingSource.DataSource = this.klant1BindingSource;
            // 
            // klantTableAdapter
            // 
            this.klantTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "klantLb";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // klantDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 466);
            this.Controls.Add(this.label1);
            this.Name = "klantDataset";
            this.Text = "klantDataset";
            this.Load += new System.EventHandler(this.klantDataset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klant1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private klant klant1;
        private System.Windows.Forms.BindingSource klant1BindingSource;
        private System.Windows.Forms.BindingSource klantBindingSource;
        private klantTableAdapters.klantTableAdapter klantTableAdapter;
        private System.Windows.Forms.Label label1;
    }
}