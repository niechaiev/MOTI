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
    public partial class CriteriaComboboxForm : Form
    {
        int ANum;
        int MNum;
        public CriteriaComboboxForm(string CName, int CNum, int MNum, int ANum)
        {
            this.ANum = ANum;
            this.MNum = MNum;
            InitializeComponent();
           
            this.markCriteriaViewTableAdapter.FillBy(this.database1DataSet.MarkCriteriaView, CNum);

            comboBox1.SelectedValue = MNum;
            label1.Text = CName;

        }

        private void CriteriaComboboxForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.MarkCriteriaView' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'database1DataSet.MarkCriteriaTable' table. You can move, or remove it, as needed.



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database1DataSetTableAdapters.VectorTableAdapter vectorTableAdapter = new Database1DataSetTableAdapters.VectorTableAdapter();
            vectorTableAdapter.Fill(database1DataSet.Vector);
            vectorTableAdapter.UpdateQuery(Convert.ToInt32(comboBox1.SelectedValue), ANum, MNum);
            Close();
        }
    }
}
