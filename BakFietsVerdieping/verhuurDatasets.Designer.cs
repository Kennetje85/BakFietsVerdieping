
namespace BakFietsVerdieping
{
    partial class verhuurDatasets
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
            this.klant = new BakFietsVerdieping.klant();
            this.verhuurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verhuurTableAdapter = new BakFietsVerdieping.klantTableAdapters.verhuurTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fKverhuuraccverhuurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.verhuuraccessoireTableAdapter = new BakFietsVerdieping.klantTableAdapters.verhuuraccessoireTableAdapter();
            this.verhuurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKverhuuraccverhuurBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
         //   this.verhuur = new BakFietsVerdieping.verhuur();
            this.verhuurBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.verhuurBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
      //      this.verhuurTableAdapter1 = new BakFietsVerdieping.verhuurTableAdapters.verhuurTableAdapter();
            this.verhuurnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verhuurdatumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakfietsnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aantaldagenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huurprijstotaalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klantnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verhuurderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.klant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKverhuuraccverhuurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKverhuuraccverhuurBindingSource1)).BeginInit();
        //    ((System.ComponentModel.ISupportInitialize)(this.verhuur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // klant
            // 
            this.klant.DataSetName = "klant";
            this.klant.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verhuurBindingSource
            // 
            this.verhuurBindingSource.DataMember = "verhuur";
            this.verhuurBindingSource.DataSource = this.klant;
            // 
            // verhuurTableAdapter
            // 
            this.verhuurTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.verhuurnummerDataGridViewTextBoxColumn,
            this.verhuurdatumDataGridViewTextBoxColumn,
            this.bakfietsnummerDataGridViewTextBoxColumn,
            this.aantaldagenDataGridViewTextBoxColumn,
            this.huurprijstotaalDataGridViewTextBoxColumn,
            this.klantnummerDataGridViewTextBoxColumn,
            this.verhuurderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.verhuurBindingSource3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1054, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // fKverhuuraccverhuurBindingSource
            // 
            this.fKverhuuraccverhuurBindingSource.DataMember = "FK_verhuuracc_verhuur";
            this.fKverhuuraccverhuurBindingSource.DataSource = this.verhuurBindingSource;
            // 
            // verhuuraccessoireTableAdapter
            // 
            this.verhuuraccessoireTableAdapter.ClearBeforeFill = true;
            // 
            // verhuurBindingSource1
            // 
            this.verhuurBindingSource1.DataMember = "verhuur";
            this.verhuurBindingSource1.DataSource = this.klant;
            // 
            // fKverhuuraccverhuurBindingSource1
            // 
            this.fKverhuuraccverhuurBindingSource1.DataMember = "FK_verhuuracc_verhuur";
            this.fKverhuuraccverhuurBindingSource1.DataSource = this.verhuurBindingSource1;
            // 
            // verhuur
            // 
        //    this.verhuur.DataSetName = "verhuur";
        //    this.verhuur.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // verhuurBindingSource2
            // 
        //    this.verhuurBindingSource2.DataSource = this.verhuur;
            this.verhuurBindingSource2.Position = 0;
            // 
            // verhuurBindingSource3
            // 
            this.verhuurBindingSource3.DataMember = "verhuur";
            this.verhuurBindingSource3.DataSource = this.verhuurBindingSource2;
            // 
            // verhuurTableAdapter1
            // 
        //    this.verhuurTableAdapter1.ClearBeforeFill = true;
            // 
            // verhuurnummerDataGridViewTextBoxColumn
            // 
            this.verhuurnummerDataGridViewTextBoxColumn.DataPropertyName = "verhuurnummer";
            this.verhuurnummerDataGridViewTextBoxColumn.HeaderText = "verhuurnummer";
            this.verhuurnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.verhuurnummerDataGridViewTextBoxColumn.Name = "verhuurnummerDataGridViewTextBoxColumn";
            this.verhuurnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // verhuurdatumDataGridViewTextBoxColumn
            // 
            this.verhuurdatumDataGridViewTextBoxColumn.DataPropertyName = "verhuurdatum";
            this.verhuurdatumDataGridViewTextBoxColumn.HeaderText = "verhuurdatum";
            this.verhuurdatumDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.verhuurdatumDataGridViewTextBoxColumn.Name = "verhuurdatumDataGridViewTextBoxColumn";
            this.verhuurdatumDataGridViewTextBoxColumn.Width = 150;
            // 
            // bakfietsnummerDataGridViewTextBoxColumn
            // 
            this.bakfietsnummerDataGridViewTextBoxColumn.DataPropertyName = "bakfietsnummer";
            this.bakfietsnummerDataGridViewTextBoxColumn.HeaderText = "bakfietsnummer";
            this.bakfietsnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bakfietsnummerDataGridViewTextBoxColumn.Name = "bakfietsnummerDataGridViewTextBoxColumn";
            this.bakfietsnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // aantaldagenDataGridViewTextBoxColumn
            // 
            this.aantaldagenDataGridViewTextBoxColumn.DataPropertyName = "aantal_dagen";
            this.aantaldagenDataGridViewTextBoxColumn.HeaderText = "aantal_dagen";
            this.aantaldagenDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aantaldagenDataGridViewTextBoxColumn.Name = "aantaldagenDataGridViewTextBoxColumn";
            this.aantaldagenDataGridViewTextBoxColumn.Width = 150;
            // 
            // huurprijstotaalDataGridViewTextBoxColumn
            // 
            this.huurprijstotaalDataGridViewTextBoxColumn.DataPropertyName = "huurprijstotaal";
            this.huurprijstotaalDataGridViewTextBoxColumn.HeaderText = "huurprijstotaal";
            this.huurprijstotaalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.huurprijstotaalDataGridViewTextBoxColumn.Name = "huurprijstotaalDataGridViewTextBoxColumn";
            this.huurprijstotaalDataGridViewTextBoxColumn.Width = 150;
            // 
            // klantnummerDataGridViewTextBoxColumn
            // 
            this.klantnummerDataGridViewTextBoxColumn.DataPropertyName = "klantnummer";
            this.klantnummerDataGridViewTextBoxColumn.HeaderText = "klantnummer";
            this.klantnummerDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.klantnummerDataGridViewTextBoxColumn.Name = "klantnummerDataGridViewTextBoxColumn";
            this.klantnummerDataGridViewTextBoxColumn.Width = 150;
            // 
            // verhuurderDataGridViewTextBoxColumn
            // 
            this.verhuurderDataGridViewTextBoxColumn.DataPropertyName = "verhuurder";
            this.verhuurderDataGridViewTextBoxColumn.HeaderText = "verhuurder";
            this.verhuurderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.verhuurderDataGridViewTextBoxColumn.Name = "verhuurderDataGridViewTextBoxColumn";
            this.verhuurderDataGridViewTextBoxColumn.Width = 150;
            // 
            // verhuurDatasets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "verhuurDatasets";
            this.Text = "verhuurDatasets";
            this.Load += new System.EventHandler(this.verhuurDatasets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKverhuuraccverhuurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKverhuuraccverhuurBindingSource1)).EndInit();
          //  ((System.ComponentModel.ISupportInitialize)(this.verhuur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verhuurBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private klant klant;
        private System.Windows.Forms.BindingSource verhuurBindingSource;
        private klantTableAdapters.verhuurTableAdapter verhuurTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fKverhuuraccverhuurBindingSource;
        private klantTableAdapters.verhuuraccessoireTableAdapter verhuuraccessoireTableAdapter;
        private System.Windows.Forms.BindingSource verhuurBindingSource1;
        private System.Windows.Forms.BindingSource verhuurBindingSource2;
       // private verhuur verhuur;
        private System.Windows.Forms.BindingSource fKverhuuraccverhuurBindingSource1;
        private System.Windows.Forms.BindingSource verhuurBindingSource3;
      //  private verhuurTableAdapters.verhuurTableAdapter verhuurTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn verhuurnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verhuurdatumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakfietsnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aantaldagenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huurprijstotaalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn klantnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verhuurderDataGridViewTextBoxColumn;
    }
}