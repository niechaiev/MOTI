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
    public partial class ResultsForm : Form
    {
        int idLPR;

        

        public ResultsForm(int idLPR)
        {
            this.idLPR = idLPR;
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet1.Result' table. You can move, or remove it, as needed.
            this.resultTableAdapter.Fill(this.database1DataSet1.Result);
            // TODO: This line of code loads data into the 'database1DataSet.ResusltView' table. You can move, or remove it, as needed.
            this.resusltViewTableAdapter.FillBy(this.database1DataSet.ResusltView, idLPR);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Alternative". При необходимости она может быть перемещена или удалена.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);

            RollForm rf = new RollForm();
            DataGridView dgv = new DataGridView();
            dgv = rf.Dgv;

            if (dataGridView1.RowCount != alternativeTableAdapter.ScalarQuery())
            {
                DataTable dt = alternativeTableAdapter.GetDataByNEW(Convert.ToInt32(resultTableAdapter.ScalarQueryMAXAnum(idLPR)));

                foreach (DataRow dr in dt.Rows)
                {
                    resultTableAdapter.InsertQuery(idLPR, Convert.ToInt32(dr["ANum"]), null, null);
                }
            }

            for (int i = 0; i < dgv.RowCount - 1; i++)
            {
                int anum = Convert.ToInt32(alternativeTableAdapter.selectByName(dgv.Rows[i].Cells[0].Value.ToString())[0][0]);
                resultTableAdapter.UpdateAWeight(Convert.ToDecimal(dgv.Rows[i].Cells[dgv.ColumnCount - 1].Value), idLPR, anum);
            }
            rf.Close();


            
            this.resusltViewTableAdapter.FillBy(this.database1DataSet.ResusltView, idLPR);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            RowSum rs = new RowSum(idLPR);
            rs.ShowDialog();
            rs.Close();
            this.resusltViewTableAdapter.FillBy(this.database1DataSet.ResusltView, idLPR);
        }
    }
}
