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
    public partial class RowSum : Form
    {
        int LNum;
        public RowSum(int ln)
        {
            LNum = ln;
            InitializeComponent();
        }

        private void RowSum_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.database1DataSet.Result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.database1DataSet.Result);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet._Relations". При необходимости она может быть перемещена или удалена.
            this.relationsTableAdapter.Fill(this.database1DataSet._Relations);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Alternative". При необходимости она может быть перемещена или удалена.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Alternative". При необходимости она может быть перемещена или удалена.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.ResusltView". При необходимости она может быть перемещена или удалена.
            foreach (DataRow dr in this.resusltViewTableAdapter.GetDataBy(LNum))
            {
                grid.Columns.Add(dr["ANum"].ToString(), dr["AName"].ToString());
            }

            foreach (DataRow dr in this.resusltViewTableAdapter.GetDataBy(LNum))
            {
                grid.Rows.Add(dr["AName"].ToString());
            }
            grid.Columns.Add("Sum", "Result of row sum");
           
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 1; j < grid.Columns.Count -1; j++)
                {
                    if (i - j == -1)
                    {
                        grid[j, i].Value = "==";
                    }
                    
                }
            }
            if (relationsTableAdapter.GetDataByLNum(LNum).Rows.Count != 0)
            {
                foreach (DataRow dr in relationsTableAdapter.GetDataByLNum(LNum))
                {
                    for (int j = 0; j < grid.RowCount; j++)
                    {
                        int firstAlt = Convert.ToInt32(alternativeTableAdapter.selectByName(grid.Rows[j].Cells[0].Value.ToString())[0][0]);
                        for (int i = j + 1; i < grid.ColumnCount - 1; i++)
                        {
                            int secondAlt = Convert.ToInt32(grid.Columns[i].Name); 
                            if (Convert.ToInt32(dr["ANum1"]) == firstAlt && Convert.ToInt32(dr["ANum2"]) == secondAlt)
                            {
                                grid[i, j].Value = dr["Relation"].ToString();
                                grid[j + 1, i - 1].Value = 1 - Convert.ToDouble(dr["Relation"]);
                            }
                        }
                    }
                }

                for (int j = 0; j < grid.RowCount; j++)
                {
                    double resRow = 0;
                    for (int i = 1; i < grid.ColumnCount -1; i++)
                    {
                        if (grid[i, j].Value != null && grid[i, j].Value.ToString() != "==")
                        {
                            resRow += Convert.ToDouble(grid[i, j].Value);
                        }
                    }
                    grid[grid.ColumnCount - 1, j].Value = resRow;
                }
            }
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int firstAlt = Convert.ToInt32(alternativeTableAdapter.selectByName((sender as DataGridView).Rows[(sender as DataGridView).SelectedCells[0].RowIndex].Cells[0].Value.ToString())[0][0]);
            int secondAlt = Convert.ToInt32((sender as DataGridView).SelectedCells[0].OwningColumn.Name.ToString());
            Relation rel = new Relation(firstAlt, secondAlt, LNum, Convert.ToInt32((sender as DataGridView).SelectedCells[0].RowIndex), Convert.ToInt32((sender as DataGridView).SelectedCells[0].ColumnIndex));
            rel.ShowDialog();
            rel.Close();

            foreach (DataRow dr in relationsTableAdapter.GetDataByLNum(LNum))
            {
                for (int j = 0; j < grid.RowCount; j++)
                {
                    firstAlt = Convert.ToInt32(alternativeTableAdapter.selectByName(grid.Rows[j].Cells[0].Value.ToString())[0][0]);
                    for (int i = j + 1; i < grid.ColumnCount - 1; i++)
                    {
                        secondAlt = Convert.ToInt32(grid.Columns[i].Name);
                        if (Convert.ToInt32(dr["ANum1"]) == firstAlt && Convert.ToInt32(dr["ANum2"]) == secondAlt)
                        {
                            grid[i, j].Value = dr["Relation"].ToString();
                            grid[j + 1, i - 1].Value = 1 - Convert.ToDouble(dr["Relation"]);
                        }
                    }
                }
            }

            for (int j = 0; j < grid.RowCount; j++)
            {
                double resRow = 0;
                for (int i = 1; i < grid.ColumnCount - 1; i++)
                {
                    if (grid[i, j].Value != null && grid[i, j].Value.ToString() != "==")
                    {
                        resRow += Convert.ToDouble(grid[i, j].Value);
                    }
                }
                grid[grid.ColumnCount - 1, j].Value = resRow;
            }
        }

        private void RowSum_FormClosing(object sender, FormClosingEventArgs e)
        {

            int rowsamount = grid.RowCount;
            double maxold = double.MaxValue;
            int rank = 0;
            for (int i = 0; i < rowsamount; i++) {
                int rowId=0;
                double max = 0;
                
               
                foreach (DataGridViewRow dgvr in grid.Rows)
                {
                    if(max< Convert.ToDouble(dgvr.Cells[grid.ColumnCount - 1].Value))
                    {
                        max = Convert.ToDouble(dgvr.Cells[grid.ColumnCount - 1].Value);
                        rowId = dgvr.Index;
                    }
                }
                if (max < maxold) rank++;
                maxold = max;

                resultTableAdapter.UpdateRANK(rank, LNum, Convert.ToInt32
                    (alternativeTableAdapter.selectByName(grid[0, rowId].Value.ToString())[0][0]));

                grid.Rows.RemoveAt(rowId);

            }
        }
    }
}
