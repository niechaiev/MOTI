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
    public partial class AlternativeCriteriesForm : Form
    {
        int ANum;
        List<int> CNums;
        public AlternativeCriteriesForm(int ANum)
        {
            this.ANum = ANum;
            InitializeComponent();
            label1.Text = alternativeTableAdapter.selectQuery(ANum).ToString();
            CheckCriteries();

           

            
        }
   
        private void CheckCriteries()
        {
            label2.Text = "";
            List<int> CNums = new List<int>();
            foreach (DataRow row in criterionTableAdapter.GetData().Rows)
            {
                CNums.Add(Convert.ToInt32(row["CNum"]));
            }

            foreach (DataRow row in alternative_information_QueryTableAdapter.GetDataByNum(ANum).Rows)
            {
                if (CNums.Contains(Convert.ToInt32(row["CNum"])))
                {
                    CNums.Remove(Convert.ToInt32(row["CNum"]));
                }
            }
            if (CNums.Count > 0)
            {
                label2.Text = "Эта альтернатива не имеет оценок по " + CNums.Count + " критериям. Назначить оценки?";
            }
            this.CNums = CNums;
        }

        private void AlternativeCriteriesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.Fill(this.database1DataSet.Criterion);
            // TODO: This line of code loads data into the 'database1DataSet.Alternative_information_Query' table. You can move, or remove it, as needed.
            this.alternative_information_QueryTableAdapter.FillByNum(this.database1DataSet.Alternative_information_Query, ANum);
          

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = (sender as DataGridView).SelectedRows[0];
            CriteriaComboboxForm comboform = new CriteriaComboboxForm((row.Cells[0].Value).ToString(), Convert.ToInt32(row.Cells[3].Value), Convert.ToInt32(row.Cells[4].Value), ANum);

            comboform.ShowDialog();
            this.alternative_information_QueryTableAdapter.FillByNum(this.database1DataSet.Alternative_information_Query, ANum);
            CheckCriteries();


        }

        private void label2_Click(object sender, EventArgs e)
        {
            AddOneCriteriaMarkForm form = new AddOneCriteriaMarkForm(CNums,ANum);
            form.ShowDialog();
            this.alternative_information_QueryTableAdapter.FillByNum(this.database1DataSet.Alternative_information_Query, ANum);
            CheckCriteries();
        }
    }
}
