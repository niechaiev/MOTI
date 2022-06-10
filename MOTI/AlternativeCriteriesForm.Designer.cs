namespace MOTI
{
    partial class AlternativeCriteriesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alternative_information_QueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new MOTI.Database1DataSet();
            this.alternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeTableAdapter = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            this.tableAdapterManager = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.alternative_information_QueryTableAdapter = new MOTI.Database1DataSetTableAdapters.Alternative_information_QueryTableAdapter();
            this.alternative_information_QueryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alternative_information_QueryTableAdapter1 = new MOTI.Database1DataSetTableAdapters.Alternative_information_QueryTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.criterionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criterionTableAdapter = new MOTI.Database1DataSetTableAdapters.CriterionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternative_information_QueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternative_information_QueryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, -20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 123);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cNameDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.CNum,
            this.MNum});
            this.dataGridView1.DataSource = this.alternative_information_QueryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(55, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(717, 327);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // cNameDataGridViewTextBoxColumn
            // 
            this.cNameDataGridViewTextBoxColumn.DataPropertyName = "CName";
            this.cNameDataGridViewTextBoxColumn.HeaderText = "CName";
            this.cNameDataGridViewTextBoxColumn.Name = "cNameDataGridViewTextBoxColumn";
            this.cNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "MName";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CNum
            // 
            this.CNum.DataPropertyName = "CNum";
            this.CNum.HeaderText = "CNum";
            this.CNum.Name = "CNum";
            this.CNum.ReadOnly = true;
            this.CNum.Visible = false;
            // 
            // MNum
            // 
            this.MNum.DataPropertyName = "MNum";
            this.MNum.HeaderText = "MNum";
            this.MNum.Name = "MNum";
            this.MNum.ReadOnly = true;
            this.MNum.Visible = false;
            // 
            // alternative_information_QueryBindingSource
            // 
            this.alternative_information_QueryBindingSource.DataMember = "Alternative information Query";
            this.alternative_information_QueryBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlternativeTableAdapter = this.alternativeTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CriterionTableAdapter = null;
            this.tableAdapterManager.LPRTableAdapter = null;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOTI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VectorTableAdapter = null;
            // 
            // alternative_information_QueryTableAdapter
            // 
            this.alternative_information_QueryTableAdapter.ClearBeforeFill = true;
            // 
            // alternative_information_QueryBindingSource1
            // 
            this.alternative_information_QueryBindingSource1.DataMember = "Alternative information Query";
            this.alternative_information_QueryBindingSource1.DataSource = this.database1DataSet;
            // 
            // alternative_information_QueryTableAdapter1
            // 
            this.alternative_information_QueryTableAdapter1.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(52, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // criterionBindingSource
            // 
            this.criterionBindingSource.DataMember = "Criterion";
            this.criterionBindingSource.DataSource = this.database1DataSet;
            // 
            // criterionTableAdapter
            // 
            this.criterionTableAdapter.ClearBeforeFill = true;
            // 
            // AlternativeCriteriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "AlternativeCriteriesForm";
            this.Text = "AlternativeCriteriesForm";
            this.Load += new System.EventHandler(this.AlternativeCriteriesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternative_information_QueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternative_information_QueryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource alternativeBindingSource;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource alternative_information_QueryBindingSource;
        private Database1DataSetTableAdapters.Alternative_information_QueryTableAdapter alternative_information_QueryTableAdapter;
        private System.Windows.Forms.BindingSource alternative_information_QueryBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSetTableAdapters.Alternative_information_QueryTableAdapter alternative_information_QueryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn MNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource criterionBindingSource;
        private Database1DataSetTableAdapters.CriterionTableAdapter criterionTableAdapter;
    }
}