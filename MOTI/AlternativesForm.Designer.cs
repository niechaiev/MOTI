namespace MOTI
{
    partial class AlternativesForm
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
            this.database1DataSet = new MOTI.Database1DataSet();
            this.alternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeTableAdapter = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            this.tableAdapterManager = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.alternativeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeDataGridView)).BeginInit();
            this.SuspendLayout();
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
            // alternativeDataGridView
            // 
            this.alternativeDataGridView.AllowUserToAddRows = false;
            this.alternativeDataGridView.AllowUserToDeleteRows = false;
            this.alternativeDataGridView.AutoGenerateColumns = false;
            this.alternativeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.alternativeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alternativeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.alternativeDataGridView.DataSource = this.alternativeBindingSource;
            this.alternativeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.alternativeDataGridView.MultiSelect = false;
            this.alternativeDataGridView.Name = "alternativeDataGridView";
            this.alternativeDataGridView.ReadOnly = true;
            this.alternativeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alternativeDataGridView.Size = new System.Drawing.Size(743, 220);
            this.alternativeDataGridView.TabIndex = 1;
            this.alternativeDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alternative_NamesDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ANum";
            this.dataGridViewTextBoxColumn1.HeaderText = "ANum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AName";
            this.dataGridViewTextBoxColumn2.HeaderText = "AName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add alternative";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 238);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(402, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Compare all";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(483, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(272, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Адитивная свертка с весовыми коэффициэнтами";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AlternativesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 267);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alternativeDataGridView);
            this.Name = "AlternativesForm";
            this.Text = "AlternativesForm";
            this.Load += new System.EventHandler(this.AlternativesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource alternativeBindingSource;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView alternativeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}