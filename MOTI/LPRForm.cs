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
    public partial class LPRForm : Form
    {
        public LPRForm()
        {
            InitializeComponent();
        }

        private void lPRBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lPRBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FacesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.LPR' table. You can move, or remove it, as needed.
            this.lPRTableAdapter.Fill(this.database1DataSet.LPR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterLPRform form = new RegisterLPRform();
            form.ShowDialog();
            this.lPRTableAdapter.Fill(this.database1DataSet.LPR);
        }

        private void lPRDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ResultsForm form = new ResultsForm(Convert.ToInt32((sender as DataGridView).SelectedRows[0].Cells[0].Value));
            form.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kondorceForm frm = new kondorceForm();
            frm.ShowDialog();
        }
    }
}
