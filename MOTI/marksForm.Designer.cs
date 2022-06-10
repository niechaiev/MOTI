namespace MOTI
{
    partial class marksForm
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
            this.mNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRankDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normMarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new MOTI.Database1DataSet();
            this.markTableAdapter = new MOTI.Database1DataSetTableAdapters.MarkTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mNumDataGridViewTextBoxColumn,
            this.cNumDataGridViewTextBoxColumn,
            this.mNameDataGridViewTextBoxColumn,
            this.mRankDataGridViewTextBoxColumn,
            this.numMarkDataGridViewTextBoxColumn,
            this.normMarkDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.markBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 35);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 353);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // mNumDataGridViewTextBoxColumn
            // 
            this.mNumDataGridViewTextBoxColumn.DataPropertyName = "MNum";
            this.mNumDataGridViewTextBoxColumn.HeaderText = "MNum";
            this.mNumDataGridViewTextBoxColumn.Name = "mNumDataGridViewTextBoxColumn";
            this.mNumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.mNumDataGridViewTextBoxColumn.Visible = false;
            // 
            // cNumDataGridViewTextBoxColumn
            // 
            this.cNumDataGridViewTextBoxColumn.DataPropertyName = "CNum";
            this.cNumDataGridViewTextBoxColumn.HeaderText = "CNum";
            this.cNumDataGridViewTextBoxColumn.Name = "cNumDataGridViewTextBoxColumn";
            this.cNumDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cNumDataGridViewTextBoxColumn.Visible = false;
            // 
            // mNameDataGridViewTextBoxColumn
            // 
            this.mNameDataGridViewTextBoxColumn.DataPropertyName = "MName";
            this.mNameDataGridViewTextBoxColumn.HeaderText = "MName";
            this.mNameDataGridViewTextBoxColumn.Name = "mNameDataGridViewTextBoxColumn";
            this.mNameDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // mRankDataGridViewTextBoxColumn
            // 
            this.mRankDataGridViewTextBoxColumn.DataPropertyName = "MRank";
            this.mRankDataGridViewTextBoxColumn.HeaderText = "MRank";
            this.mRankDataGridViewTextBoxColumn.Name = "mRankDataGridViewTextBoxColumn";
            this.mRankDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // numMarkDataGridViewTextBoxColumn
            // 
            this.numMarkDataGridViewTextBoxColumn.DataPropertyName = "NumMark";
            this.numMarkDataGridViewTextBoxColumn.HeaderText = "NumMark";
            this.numMarkDataGridViewTextBoxColumn.Name = "numMarkDataGridViewTextBoxColumn";
            this.numMarkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // normMarkDataGridViewTextBoxColumn
            // 
            this.normMarkDataGridViewTextBoxColumn.DataPropertyName = "NormMark";
            this.normMarkDataGridViewTextBoxColumn.HeaderText = "NormMark";
            this.normMarkDataGridViewTextBoxColumn.Name = "normMarkDataGridViewTextBoxColumn";
            this.normMarkDataGridViewTextBoxColumn.ReadOnly = true;
            this.normMarkDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // markBindingSource
            // 
            this.markBindingSource.DataMember = "Mark";
            this.markBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markTableAdapter
            // 
            this.markTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить и нормализовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // marksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "marksForm";
            this.Text = "marksForm";
            this.Load += new System.EventHandler(this.marksForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource markBindingSource;
        private Database1DataSetTableAdapters.MarkTableAdapter markTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRankDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numMarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normMarkDataGridViewTextBoxColumn;
    }
}