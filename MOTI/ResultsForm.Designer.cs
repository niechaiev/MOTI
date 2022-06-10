namespace MOTI
{
    partial class ResultsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.resusltViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new MOTI.Database1DataSet();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultTableAdapter = new MOTI.Database1DataSetTableAdapters.ResultTableAdapter();
            this.resusltViewTableAdapter = new MOTI.Database1DataSetTableAdapters.ResusltViewTableAdapter();
            this.database1DataSet1 = new MOTI.Database1DataSet();
            this.resultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeTableAdapter = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            this.tableAdapterManager = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.lNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resusltViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lNumDataGridViewTextBoxColumn,
            this.anumDataGridViewTextBoxColumn,
            this.aNameDataGridViewTextBoxColumn,
            this.rankDataGridViewTextBoxColumn,
            this.aWeightDataGridViewTextBoxColumn,
            this.rNumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resusltViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1035, 489);
            this.dataGridView1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(407, 511);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(249, 28);
            this.button2.TabIndex = 2;
            this.button2.Text = "Таблица попарных сравнений";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // resusltViewBindingSource
            // 
            this.resusltViewBindingSource.DataMember = "ResusltView";
            this.resusltViewBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // resusltViewTableAdapter
            // 
            this.resusltViewTableAdapter.ClearBeforeFill = true;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultBindingSource1
            // 
            this.resultBindingSource1.DataMember = "Result";
            this.resultBindingSource1.DataSource = this.database1DataSet1;
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
            this.tableAdapterManager.ResultTableAdapter = this.resultTableAdapter;
            this.tableAdapterManager.UpdateOrder = MOTI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VectorTableAdapter = null;
            // 
            // lNumDataGridViewTextBoxColumn
            // 
            this.lNumDataGridViewTextBoxColumn.DataPropertyName = "LNum";
            this.lNumDataGridViewTextBoxColumn.HeaderText = "LNum";
            this.lNumDataGridViewTextBoxColumn.Name = "lNumDataGridViewTextBoxColumn";
            this.lNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.lNumDataGridViewTextBoxColumn.Visible = false;
            // 
            // anumDataGridViewTextBoxColumn
            // 
            this.anumDataGridViewTextBoxColumn.DataPropertyName = "Anum";
            this.anumDataGridViewTextBoxColumn.HeaderText = "Anum";
            this.anumDataGridViewTextBoxColumn.Name = "anumDataGridViewTextBoxColumn";
            this.anumDataGridViewTextBoxColumn.ReadOnly = true;
            this.anumDataGridViewTextBoxColumn.Visible = false;
            // 
            // aNameDataGridViewTextBoxColumn
            // 
            this.aNameDataGridViewTextBoxColumn.DataPropertyName = "AName";
            this.aNameDataGridViewTextBoxColumn.HeaderText = "AName";
            this.aNameDataGridViewTextBoxColumn.Name = "aNameDataGridViewTextBoxColumn";
            this.aNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rankDataGridViewTextBoxColumn
            // 
            this.rankDataGridViewTextBoxColumn.DataPropertyName = "Rank";
            this.rankDataGridViewTextBoxColumn.HeaderText = "Rank";
            this.rankDataGridViewTextBoxColumn.Name = "rankDataGridViewTextBoxColumn";
            this.rankDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aWeightDataGridViewTextBoxColumn
            // 
            this.aWeightDataGridViewTextBoxColumn.DataPropertyName = "AWeight";
            this.aWeightDataGridViewTextBoxColumn.HeaderText = "AWeight";
            this.aWeightDataGridViewTextBoxColumn.Name = "aWeightDataGridViewTextBoxColumn";
            this.aWeightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rNumDataGridViewTextBoxColumn
            // 
            this.rNumDataGridViewTextBoxColumn.DataPropertyName = "RNum";
            this.rNumDataGridViewTextBoxColumn.HeaderText = "RNum";
            this.rNumDataGridViewTextBoxColumn.Name = "rNumDataGridViewTextBoxColumn";
            this.rNumDataGridViewTextBoxColumn.ReadOnly = true;
            this.rNumDataGridViewTextBoxColumn.Visible = false;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 559);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ResultsForm";
            this.Text = "ResultsForm";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resusltViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private Database1DataSetTableAdapters.ResultTableAdapter resultTableAdapter;
        private System.Windows.Forms.BindingSource resusltViewBindingSource;
        private Database1DataSetTableAdapters.ResusltViewTableAdapter resusltViewTableAdapter;
        private System.Windows.Forms.Button button2;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.BindingSource resultBindingSource1;
        private System.Windows.Forms.BindingSource alternativeBindingSource;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn lNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rNumDataGridViewTextBoxColumn;
    }
}