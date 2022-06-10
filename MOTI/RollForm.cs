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
    public partial class RollForm : Form
    {
        public DataGridView Dgv { get; set; }
        public RollForm()
        {
            InitializeComponent();
            foreach(DataRow row in criterionTableAdapter.GetDataByOrdered())
            {
                grid.Columns.Add(row["CNum"].ToString(), row["CName"].ToString());
            }
            grid.Columns.Add("RESULT","Результат свертки с весовыми коэффициентами" );
            foreach (DataRow row in alternativeTableAdapter.GetData())
            {
                grid.Rows.Add(row["AName"].ToString());
            }

            foreach (DataRow row in alternative_information_QueryTableAdapter.GetData())
            {

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    if (grid.Rows[i].Cells[0].Value.ToString() == row["AName"].ToString())
                    {
                        grid.Rows[i].Cells[row["CNum"].ToString()].Value = row["NormMark"].ToString();
                        break;
                    }
                }
            }

            int WeightSum = Convert.ToInt32(criterionTableAdapter.ScalarQuery());
            grid.Rows.Add("Весовые коэффициенты");
            for(int i = 1; i < grid.Columns.Count - 1; i++)
            {
                grid.Rows[grid.RowCount - 1].Cells[i].Value = Convert.ToDouble(criterionTableAdapter.GetByCNum(Convert.ToInt32(grid.Columns[i].Name))[0]["CWeight"]) / WeightSum;
            }

            for (int j = 0; j < grid.RowCount - 1; j++)
            {
                double result = 0;
                for (int i = 1; i < grid.Rows[j].Cells.Count - 2; i++)
                {
                    result += Convert.ToDouble(grid.Rows[j].Cells[i].Value) * Convert.ToDouble(grid.Rows[grid.RowCount-1].Cells[i].Value);
                }
                grid.Rows[j].Cells[grid.Rows[j].Cells.Count - 1].Value = result;

            }
            Dgv = grid;

        }

        private void RollForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Alternative' table. You can move, or remove it, as needed.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
            // TODO: This line of code loads data into the 'database1DataSet.Alternative_information_Query' table. You can move, or remove it, as needed.
            this.alternative_information_QueryTableAdapter.Fill(this.database1DataSet.Alternative_information_Query);
            // TODO: This line of code loads data into the 'database1DataSet.Mark' table. You can move, or remove it, as needed.
            this.markTableAdapter.Fill(this.database1DataSet.Mark);
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.FillByOrdered(this.database1DataSet.Criterion);

        }
    }
}
