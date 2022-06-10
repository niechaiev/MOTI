namespace MOTI
{
    partial class AlternativeCreationForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mark = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.database1DataSet = new MOTI.Database1DataSet();
            this.markCriteriaViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markCriteriaViewTableAdapter = new MOTI.Database1DataSetTableAdapters.MarkCriteriaViewTableAdapter();
            this.criterionTableAdapter1 = new MOTI.Database1DataSetTableAdapters.CriterionTableAdapter();
            this.alternativeTableAdapter1 = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            this.vectorTableAdapter1 = new MOTI.Database1DataSetTableAdapters.VectorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markCriteriaViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CNum,
            this.Mark});
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(245, 365);
            this.dataGridView1.TabIndex = 1;
            // 
            // CName
            // 
            this.CName.HeaderText = "CName";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            // 
            // CNum
            // 
            this.CNum.HeaderText = "CNum";
            this.CNum.Name = "CNum";
            this.CNum.ReadOnly = true;
            this.CNum.Visible = false;
            // 
            // Mark
            // 
            this.Mark.HeaderText = "Mark";
            this.Mark.Name = "Mark";
            this.Mark.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Mark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Alternative\'s name";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markCriteriaViewBindingSource
            // 
            this.markCriteriaViewBindingSource.DataMember = "MarkCriteriaView";
            this.markCriteriaViewBindingSource.DataSource = this.database1DataSet;
            // 
            // markCriteriaViewTableAdapter
            // 
            this.markCriteriaViewTableAdapter.ClearBeforeFill = true;
            // 
            // criterionTableAdapter1
            // 
            this.criterionTableAdapter1.ClearBeforeFill = true;
            // 
            // alternativeTableAdapter1
            // 
            this.alternativeTableAdapter1.ClearBeforeFill = true;
            // 
            // vectorTableAdapter1
            // 
            this.vectorTableAdapter1.ClearBeforeFill = true;
            // 
            // AlternativeCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "AlternativeCreationForm";
            this.Text = "AlternativeCreationForm";
            this.Load += new System.EventHandler(this.AlternativeCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markCriteriaViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource markCriteriaViewBindingSource;
        private Database1DataSetTableAdapters.MarkCriteriaViewTableAdapter markCriteriaViewTableAdapter;
        private Database1DataSetTableAdapters.CriterionTableAdapter criterionTableAdapter1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter1;
        private Database1DataSetTableAdapters.VectorTableAdapter vectorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn Mark;
    }
}