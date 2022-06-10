using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOTI
{
    public partial class AlternativesForm : Form
    {
        public AlternativesForm()
        {
            InitializeComponent();
        }


        private void AlternativesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Alternative' table. You can move, or remove it, as needed.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);

            alternativeDataGridView.Columns[0].Visible = false;

        }

        private void alternative_NamesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int altIdx = Convert.ToInt32((sender as DataGridView).Rows[e.RowIndex].Cells[0].Value);
            AlternativeCriteriesForm critform = new AlternativeCriteriesForm(altIdx);
            critform.ShowDialog();
        }

        private void alternativeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.alternativeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AlternativeCreationForm creatForm = new AlternativeCreationForm();
            creatForm.ShowDialog();
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(alternativeDataGridView.SelectedRows != null)
                alternativeTableAdapter.DeleteQuery(Convert.ToInt32(alternativeDataGridView.SelectedRows[0].Cells[0].Value));
            
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ComparationForm form = new ComparationForm();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RollForm form = new RollForm();
            form.ShowDialog();
        }
    }
}
