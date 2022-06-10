namespace MOTI
{
    partial class LPRForm
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
            this.lPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lPRTableAdapter = new MOTI.Database1DataSetTableAdapters.LPRTableAdapter();
            this.tableAdapterManager = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.lPRDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPRDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lPRBindingSource
            // 
            this.lPRBindingSource.DataMember = "LPR";
            this.lPRBindingSource.DataSource = this.database1DataSet;
            // 
            // lPRTableAdapter
            // 
            this.lPRTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlternativeTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CriterionTableAdapter = null;
            this.tableAdapterManager.LPRTableAdapter = this.lPRTableAdapter;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.RelationsTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOTI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VectorTableAdapter = null;
            // 
            // lPRDataGridView
            // 
            this.lPRDataGridView.AllowUserToAddRows = false;
            this.lPRDataGridView.AllowUserToDeleteRows = false;
            this.lPRDataGridView.AutoGenerateColumns = false;
            this.lPRDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lPRDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lPRDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lPRDataGridView.DataSource = this.lPRBindingSource;
            this.lPRDataGridView.Location = new System.Drawing.Point(12, 12);
            this.lPRDataGridView.Name = "lPRDataGridView";
            this.lPRDataGridView.ReadOnly = true;
            this.lPRDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lPRDataGridView.Size = new System.Drawing.Size(776, 397);
            this.lPRDataGridView.TabIndex = 1;
            this.lPRDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lPRDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "LNum";
            this.dataGridViewTextBoxColumn1.HeaderText = "LNum";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LName";
            this.dataGridViewTextBoxColumn2.HeaderText = "LName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LRank";
            this.dataGridViewTextBoxColumn3.HeaderText = "LRank";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(482, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Кондорсе&&Коплэнд";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LPRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lPRDataGridView);
            this.Name = "LPRForm";
            this.Text = "FacesForm";
            this.Load += new System.EventHandler(this.FacesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPRDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource lPRBindingSource;
        private Database1DataSetTableAdapters.LPRTableAdapter lPRTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lPRDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}