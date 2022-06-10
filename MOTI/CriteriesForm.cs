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
    public partial class CriteriesForm : Form
    {
        public CriteriesForm()
        {
            InitializeComponent();
        }

        private void criterionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criterionBindingSource.EndEdit();
            this.criterionTableAdapter.Update(this.database1DataSet);
        }

        private void CriteriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.FillByOrdered(this.database1DataSet.Criterion);



        }


        private void criterionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((sender as DataGridView).SelectedCells[0] is DataGridViewButtonCell)
            {
                int CNum = Convert.ToInt32(criterionDataGridView.Rows[(sender as DataGridView).SelectedCells[0].RowIndex].Cells[0].Value);
                string CName = criterionDataGridView.Rows[(sender as DataGridView).SelectedCells[0].RowIndex].Cells[1].Value.ToString();
                string CType = criterionDataGridView.Rows[(sender as DataGridView).SelectedCells[0].RowIndex].Cells[4].Value.ToString();
                string OptimType = criterionDataGridView.Rows[(sender as DataGridView).SelectedCells[0].RowIndex].Cells[5].Value.ToString();
                string Unit = criterionDataGridView.Rows[(sender as DataGridView).SelectedCells[0].RowIndex].Cells[6].Value.ToString();
                marksForm forma = new marksForm(CNum, CName, CType, OptimType, Unit); 

                this.Validate();
                this.criterionBindingSource.EndEdit();
                this.criterionTableAdapter.Update(this.database1DataSet);

                forma.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criterionBindingSource.EndEdit();
            this.criterionTableAdapter.Update(this.database1DataSet);

            WeightsForm form = new WeightsForm();
            form.ShowDialog();
            this.criterionTableAdapter.FillByOrdered(this.database1DataSet.Criterion);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.criterionBindingSource.EndEdit();
            this.criterionTableAdapter.Update(this.database1DataSet);
            SUCCess form = new SUCCess("Критерии сохранены");
            form.ShowDialog();
        }

        private void criterionDataGridView_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            e.Row.Cells[3].Value = "1";
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }
    }
}
