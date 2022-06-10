namespace MOTI
{
    partial class RowSum
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.Alternative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet = new MOTI.Database1DataSet();
            this.resusltViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resusltViewTableAdapter = new MOTI.Database1DataSetTableAdapters.ResusltViewTableAdapter();
            this.tableAdapterManager = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.alternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeTableAdapter = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            this.relationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relationsTableAdapter = new MOTI.Database1DataSetTableAdapters.RelationsTableAdapter();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTableAdapter = new MOTI.Database1DataSetTableAdapters.ResultTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resusltViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Alternative});
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(721, 498);
            this.grid.TabIndex = 0;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // Alternative
            // 
            this.Alternative.HeaderText = "Alternative";
            this.Alternative.Name = "Alternative";
            this.Alternative.ReadOnly = true;
            this.Alternative.Width = 104;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resusltViewBindingSource
            // 
            this.resusltViewBindingSource.DataMember = "ResusltView";
            this.resusltViewBindingSource.DataSource = this.database1DataSet;
            // 
            // resusltViewTableAdapter
            // 
            this.resusltViewTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlternativeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CriterionTableAdapter = null;
            this.tableAdapterManager.LPRTableAdapter = null;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.RelationsTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOTI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VectorTableAdapter = null;
            // 
            // alternativeBindingSource
            // 
            this.alternativeBindingSource.DataMember = "Alternative";
            this.alternativeBindingSource.DataSource = this.database1DataSet;
            // 
            // alternativeTableAdapter
            // 
            this.alternativeTableAdapter.ClearBeforeFill = true;
            // 
            // relationsBindingSource
            // 
            this.relationsBindingSource.DataMember = "Relations";
            this.relationsBindingSource.DataSource = this.database1DataSet;
            // 
            // relationsTableAdapter
            // 
            this.relationsTableAdapter.ClearBeforeFill = true;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataMember = "Result";
            this.resultBindingSource.DataSource = this.database1DataSet;
            // 
            // resultTableAdapter
            // 
            this.resultTableAdapter.ClearBeforeFill = true;
            // 
            // RowSum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 518);
            this.Controls.Add(this.grid);
            this.Name = "RowSum";
            this.Text = "RowSum";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RowSum_FormClosing);
            this.Load += new System.EventHandler(this.RowSum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resusltViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alternative;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource resusltViewBindingSource;
        private Database1DataSetTableAdapters.ResusltViewTableAdapter resusltViewTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource alternativeBindingSource;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter;
        private System.Windows.Forms.BindingSource relationsBindingSource;
        private Database1DataSetTableAdapters.RelationsTableAdapter relationsTableAdapter;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private Database1DataSetTableAdapters.ResultTableAdapter resultTableAdapter;
    }
}