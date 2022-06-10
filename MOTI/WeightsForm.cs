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
    public partial class WeightsForm : Form
    {
        public WeightsForm()
        {
            InitializeComponent();
            this.criterionTableAdapter.FillByOrdered(this.database1DataSet.Criterion);

            foreach (DataRow row in database1DataSet.Criterion)
            {
                
                dataGridView1.Rows.Add(row["CNum"], row["CName"]);
                dataGridView2.Rows.Add(row["CNum"], row["CName"]);
                dataGridView2.Rows[dataGridView2.RowCount-1].Cells[2].Value = row["CWeight"];

            }
            int divider = 1;
            for (int i=dataGridView2.RowCount-1; i >=0; i--)
            {
                
                dataGridView1.Rows[i].Cells[2].Value = (Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value)/divider).ToString();
                divider *= Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }

          
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2] = new DataGridViewTextBoxCell();

        }

        private void WeightsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.Fill(this.database1DataSet.Criterion);
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.Fill(this.database1DataSet.Criterion);
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.




        }
        private void moveRow(int one)
        {
            DataGridViewComboBoxCell cmb = new DataGridViewComboBoxCell();
            cmb.DataSource = (dataGridView1.Rows[0].Cells[2] as DataGridViewComboBoxCell).Items;
            cmb.Value = "1";
            

            int selInd = dataGridView1.SelectedRows[0].Index;
            int nextInd = selInd + one;
            if (nextInd < 0 || nextInd >= dataGridView1.Rows.Count) return;
            DataGridViewRow r10 = dataGridView1.Rows[selInd];
            DataGridViewRow r1 = dataGridView1.Rows[nextInd];
            if(selInd == dataGridView1.RowCount - 1)
            {
                r10.Cells[2] = cmb;
            }
            if (nextInd == dataGridView1.RowCount - 1)
            {
                r1.Cells[2] = cmb;
            }

            dataGridView1.Rows.Remove(r1);
            dataGridView1.Rows.Remove(r10);
            

            if (one == 1)
            {
                dataGridView1.Rows.Insert(selInd, r1);
                dataGridView1.Rows.Insert(nextInd, r10);
            }
            if (one == -1)
            {
                dataGridView1.Rows.Insert(nextInd, r10);
                dataGridView1.Rows.Insert(selInd, r1);               
            }
            dataGridView1.Rows[nextInd].Selected = true;
            dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[2] = new DataGridViewTextBoxCell();
            updateGrid2();
        }

        private void updateGrid2()
        {
            dataGridView2.Rows.Clear();
            int i = 0;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                dataGridView2.Rows.Add(row.Cells[0].Value, row.Cells[1].Value);
                int weight = 1;

                for(int j = i; j< dataGridView1.RowCount-1; j++)
                     weight *= Convert.ToInt32(dataGridView1.Rows[j].Cells[2].Value);
               
                dataGridView2.Rows[i++].Cells[2].Value = weight;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            moveRow(-1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveRow(1);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            updateGrid2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.Rows)
                criterionTableAdapter.UpdateWeight(Convert.ToInt32(row.Cells[2].Value), Convert.ToInt32(row.Cells[0].Value));
            SUCCess form = new SUCCess("Весовые коэффициенты сохранены");
            form.ShowDialog();
            Close();



            //int sum = 0;
            //foreach(DataGridViewRow row in dataGridView2.Rows)
            //{
            //    sum += Convert.ToInt32(row.Cells[2].Value);
            //}
            //foreach (DataGridViewRow row in dataGridView2.Rows)
            //{
            //   criterionTableAdapter.UpdateWeight((decimal)Convert.ToInt32(row.Cells[2].Value) / sum, Convert.ToInt32(row.Cells[0].Value));

            //}
        }
    }
}
