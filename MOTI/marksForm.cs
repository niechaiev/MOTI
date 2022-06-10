using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MOTI
{


    public partial class marksForm : Form
    {
        int CNum;
        string CType;
        string OptimType;
        List<int> itemsToDelete = new List<int>();
        public marksForm(int CNum, string CName, string CType, string OptimType, string Unit)
        {
            this.CType = CType;
            this.OptimType = OptimType;
            this.CNum = CNum;
            InitializeComponent();
            dataGridView1.Columns[2].HeaderText = CName;
            if (Unit != string.Empty)           
                dataGridView1.Columns[2].HeaderText+= " (" + Unit + ")";   

        }

    

        private void marksForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Mark' table. You can move, or remove it, as needed.

            dataGridView1.Columns[5].HeaderText += "(ReadOnly)";
            if (CType == "Количественный")
            {
                database1DataSet.Mark.MNameColumn.DataType = typeof(double);
                dataGridView1.Columns[3].ReadOnly = true;
                dataGridView1.Columns[3].HeaderText += "(ReadOnly)";

                if (OptimType == "Максимум")
                    dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Ascending);
                else if(OptimType == "Минимум")
                    dataGridView1.Sort(dataGridView1.Columns[2], ListSortDirection.Descending);
            }
            else if (CType == "Качественный") {
                dataGridView1.Sort(dataGridView1.Columns[3], ListSortDirection.Ascending);
            }
            this.markTableAdapter.FillByCNum(database1DataSet.Mark, CNum);

        }

        private void customSortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            int a = int.Parse(e.CellValue1.ToString()), b = int.Parse(e.CellValue2.ToString());

            // If the cell value is already an integer, just cast it instead of parsing

            e.SortResult = a.CompareTo(b);

            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


            if(CType == "Качественный")
            {
                double min = int.Parse(dataGridView1.Rows[0].Cells[3].Value.ToString());
                double max = int.Parse(dataGridView1.Rows[dataGridView1.RowCount - 2].Cells[3].Value.ToString()); ;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells[5].Value = (double.Parse(row.Cells[3].Value.ToString()) - min) / (max - min);
                    }
                }
            }
            else if(CType == "Количественный")
            {
                int i = 1;
                double min = double.Parse(dataGridView1.Rows[0].Cells[2].Value.ToString());
                double max = double.Parse(dataGridView1.Rows[dataGridView1.RowCount-2].Cells[2].Value.ToString()); ;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        row.Cells[3].Value = i++;
                        row.Cells[5].Value = (double.Parse(row.Cells[2].Value.ToString()) - min) / (max - min);
                    }
                }

            }


            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;
                if (markTableAdapter.GetDataByMNum(Convert.ToInt32(row.Cells[0].Value)).Rows.Count > 0)
                {
                    markTableAdapter.UpdateQuery(CNum, row.Cells[2].Value.ToString(),
                        Convert.ToInt32(row.Cells[3].Value),
                        Convert.ToInt32(row.Cells[4].Value),
                        Convert.ToDecimal(row.Cells[5].Value),
                        Convert.ToInt32(row.Cells[0].Value));


                }
                else
                {
                    markTableAdapter.InsertQuery(CNum, row.Cells[2].Value.ToString(),
                        Convert.ToInt32(row.Cells[3].Value),
                        Convert.ToInt32(row.Cells[4].Value),
                        Convert.ToDecimal(row.Cells[5].Value));

                }
            }
            foreach(int i in itemsToDelete)
            {
                markTableAdapter.DeleteQuery(i);
            }


            SUCCess form = new SUCCess("Шкала оценок сохранена");
            form.ShowDialog();
            Close();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            itemsToDelete.Add(Convert.ToInt32((sender as DataGridView).SelectedRows[0].Cells[0].Value));

        }

    }
}
