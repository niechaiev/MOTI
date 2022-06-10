namespace MOTI
{
    partial class RollForm
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database1DataSet = new MOTI.Database1DataSet();
            this.criterionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criterionTableAdapter = new MOTI.Database1DataSetTableAdapters.CriterionTableAdapter();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markTableAdapter = new MOTI.Database1DataSetTableAdapters.MarkTableAdapter();
            this.alternativeInformationQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternative_information_QueryTableAdapter = new MOTI.Database1DataSetTableAdapters.Alternative_information_QueryTableAdapter();
            this.alternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeTableAdapter = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeInformationQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(1165, 426);
            this.grid.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Критерий";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // markBindingSource
            // 
            this.markBindingSource.DataMember = "Mark";
            this.markBindingSource.DataSource = this.database1DataSet;
            // 
            // markTableAdapter
            // 
            this.markTableAdapter.ClearBeforeFill = true;
            // 
            // alternativeInformationQueryBindingSource
            // 
            this.alternativeInformationQueryBindingSource.DataMember = "Alternative information Query";
            this.alternativeInformationQueryBindingSource.DataSource = this.database1DataSet;
            // 
            // alternative_information_QueryTableAdapter
            // 
            this.alternative_information_QueryTableAdapter.ClearBeforeFill = true;
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
            // RollForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 450);
            this.Controls.Add(this.grid);
            this.Name = "RollForm";
            this.Text = "RollForm";
            this.Load += new System.EventHandler(this.RollForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeInformationQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource criterionBindingSource;
        private Database1DataSetTableAdapters.CriterionTableAdapter criterionTableAdapter;
        private System.Windows.Forms.BindingSource markBindingSource;
        private Database1DataSetTableAdapters.MarkTableAdapter markTableAdapter;
        private System.Windows.Forms.BindingSource alternativeInformationQueryBindingSource;
        private Database1DataSetTableAdapters.Alternative_information_QueryTableAdapter alternative_information_QueryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource alternativeBindingSource;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter;
    }
}