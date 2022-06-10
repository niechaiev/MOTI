namespace MOTI
{
    partial class kondorceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid = new System.Windows.Forms.DataGridView();
            this.database1DataSet = new MOTI.Database1DataSet();
            this.resusltViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resusltViewTableAdapter = new MOTI.Database1DataSetTableAdapters.ResusltViewTableAdapter();
            this.tableAdapterManager = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.lPRTableAdapter = new MOTI.Database1DataSetTableAdapters.LPRTableAdapter();
            this.lPRBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new MOTI.Database1DataSetTableAdapters.TableAdapterManager();
            this.alternativeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alternativeTableAdapter = new MOTI.Database1DataSetTableAdapters.AlternativeTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resusltViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPRBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle1;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.Size = new System.Drawing.Size(910, 426);
            this.grid.TabIndex = 0;
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
            this.tableAdapterManager.CriterionTableAdapter = null;
            this.tableAdapterManager.LPRTableAdapter = this.lPRTableAdapter;
            this.tableAdapterManager.MarkTableAdapter = null;
            this.tableAdapterManager.RelationsTableAdapter = null;
            this.tableAdapterManager.ResultTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = MOTI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VectorTableAdapter = null;
            // 
            // lPRTableAdapter
            // 
            this.lPRTableAdapter.ClearBeforeFill = true;
            // 
            // lPRBindingSource
            // 
            this.lPRBindingSource.DataMember = "LPR";
            this.lPRBindingSource.DataSource = this.database1DataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.AlternativeTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.CriterionTableAdapter = null;
            this.tableAdapterManager1.LPRTableAdapter = null;
            this.tableAdapterManager1.MarkTableAdapter = null;
            this.tableAdapterManager1.RelationsTableAdapter = null;
            this.tableAdapterManager1.ResultTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = MOTI.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VectorTableAdapter = null;
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
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(928, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(438, 425);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(928, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Кондорсе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1009, 440);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Коплэнд";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kondorceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1378, 475);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.grid);
            this.Name = "kondorceForm";
            this.Text = "koplandForm";
            this.Load += new System.EventHandler(this.koplandForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resusltViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPRBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alternativeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource resusltViewBindingSource;
        private Database1DataSetTableAdapters.ResusltViewTableAdapter resusltViewTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.LPRTableAdapter lPRTableAdapter;
        private System.Windows.Forms.BindingSource lPRBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource alternativeBindingSource;
        private Database1DataSetTableAdapters.AlternativeTableAdapter alternativeTableAdapter;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}