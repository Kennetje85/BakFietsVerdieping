
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.klantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.klantTableAdapter = new BakFietsVerdieping.klantTableAdapters.klantTableAdapter();
            this.klantnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voornaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huisnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huisnummertoevoegingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opmerkingenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.klant1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.klant1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.klantnummerDataGridViewTextBoxColumn,
            this.naamDataGridViewTextBoxColumn,
            this.voornaamDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.huisnummerDataGridViewTextBoxColumn,
            this.huisnummertoevoegingDataGridViewTextBoxColumn,
            this.opmerkingenDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.klantBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1108, 466);
            this.dataGridView1.TabIndex = 0;
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
            // klantnummerDataGridViewTextBoxColumn
            // 
            this.klantnummerDataGridViewTextBoxColumn.DataPropertyName = "klantnummer";
            this.klantnummerDataGridViewTextBoxColumn.HeaderText = "klantnummer";
            this.klantnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.klantnummerDataGridViewTextBoxColumn.Name = "klantnummerDataGridViewTextBoxColumn";
            this.klantnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // naamDataGridViewTextBoxColumn
            // 
            this.naamDataGridViewTextBoxColumn.DataPropertyName = "naam";
            this.naamDataGridViewTextBoxColumn.HeaderText = "naam";
            this.naamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.naamDataGridViewTextBoxColumn.Name = "naamDataGridViewTextBoxColumn";
            this.naamDataGridViewTextBoxColumn.Width = 150;
            // 
            // voornaamDataGridViewTextBoxColumn
            // 
            this.voornaamDataGridViewTextBoxColumn.DataPropertyName = "voornaam";
            this.voornaamDataGridViewTextBoxColumn.HeaderText = "voornaam";
            this.voornaamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.voornaamDataGridViewTextBoxColumn.Name = "voornaamDataGridViewTextBoxColumn";
            this.voornaamDataGridViewTextBoxColumn.Width = 150;
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "postcode";
            this.postcodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            this.postcodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // huisnummerDataGridViewTextBoxColumn
            // 
            this.huisnummerDataGridViewTextBoxColumn.DataPropertyName = "huisnummer";
            this.huisnummerDataGridViewTextBoxColumn.HeaderText = "huisnummer";
            this.huisnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.huisnummerDataGridViewTextBoxColumn.Name = "huisnummerDataGridViewTextBoxColumn";
            this.huisnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // huisnummertoevoegingDataGridViewTextBoxColumn
            // 
            this.huisnummertoevoegingDataGridViewTextBoxColumn.DataPropertyName = "huisnummer_toevoeging";
            this.huisnummertoevoegingDataGridViewTextBoxColumn.HeaderText = "huisnummer_toevoeging";
            this.huisnummertoevoegingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.huisnummertoevoegingDataGridViewTextBoxColumn.Name = "huisnummertoevoegingDataGridViewTextBoxColumn";
            this.huisnummertoevoegingDataGridViewTextBoxColumn.Width = 150;
            // 
            // opmerkingenDataGridViewTextBoxColumn
            // 
            this.opmerkingenDataGridViewTextBoxColumn.DataPropertyName = "opmerkingen";
            this.opmerkingenDataGridViewTextBoxColumn.HeaderText = "opmerkingen";
            this.opmerkingenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.opmerkingenDataGridViewTextBoxColumn.Name = "opmerkingenDataGridViewTextBoxColumn";
            this.opmerkingenDataGridViewTextBoxColumn.Width = 150;
            // 
            // klantDataset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 466);
            this.Controls.Add(this.dataGridView1);
            this.Name = "klantDataset";
            this.Text = "klantDataset";
            this.Load += new System.EventHandler(this.klantDataset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klant1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klant1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.klantBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private klant klant1;
        private System.Windows.Forms.BindingSource klant1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource klantBindingSource;
        private klantTableAdapters.klantTableAdapter klantTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn klantnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voornaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huisnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huisnummertoevoegingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opmerkingenDataGridViewTextBoxColumn;
    }
}