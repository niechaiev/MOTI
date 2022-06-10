namespace MOTI
{
    partial class AddOneCriteriaMarkForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.database1DataSet = new MOTI.Database1DataSet();
            this.criterionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.criterionTableAdapter = new MOTI.Database1DataSetTableAdapters.CriterionTableAdapter();
            this.markBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markTableAdapter = new MOTI.Database1DataSetTableAdapters.MarkTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.vectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vectorTableAdapter = new MOTI.Database1DataSetTableAdapters.VectorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Критерий";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оценка";
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vectorBindingSource
            // 
            this.vectorBindingSource.DataMember = "Vector";
            this.vectorBindingSource.DataSource = this.database1DataSet;
            // 
            // vectorTableAdapter
            // 
            this.vectorTableAdapter.ClearBeforeFill = true;
            // 
            // AddOneCriteriaMarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 86);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "AddOneCriteriaMarkForm";
            this.Text = "AddOneCriteriaMarkForm";
            this.Load += new System.EventHandler(this.AddOneCriteriaMarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.criterionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vectorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource criterionBindingSource;
        private Database1DataSetTableAdapters.CriterionTableAdapter criterionTableAdapter;
        private System.Windows.Forms.BindingSource markBindingSource;
        private Database1DataSetTableAdapters.MarkTableAdapter markTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vectorBindingSource;
        private Database1DataSetTableAdapters.VectorTableAdapter vectorTableAdapter;
    }
}