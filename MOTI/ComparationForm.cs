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
    public partial class ComparationForm : Form
    {
        public ComparationForm()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("CName", "Критерии");

            
            
            foreach(DataRow row in alternativeTableAdapter.GetData())
            {
                dataGridView1.Columns.Add(row["ANum"].ToString(), row["AName"].ToString());
            }
            
            foreach(DataRow row in criterionTableAdapter.GetData())
            {
                dataGridView1.Rows.Add(row["CName"].ToString());
            }

            foreach(DataRow row in alternative_information_QueryTableAdapter.GetData())
            {

                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == row["CName"].ToString())
                    {
                        dataGridView1.Rows[i].Cells[row["ANum"].ToString()].Value = row["MName"].ToString() + " " + row["Unit"].ToString();
                        break;
                    }
                }


            }
        }

        private void ComparationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet1.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.Fill(this.database1DataSet1.Criterion);
            // TODO: This line of code loads data into the 'database1DataSet.Alternative' table. You can move, or remove it, as needed.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
            // TODO: This line of code loads data into the 'database1DataSet.Alternative_information_Query' table. You can move, or remove it, as needed.
            this.alternative_information_QueryTableAdapter.Fill(this.database1DataSet.Alternative_information_Query);

        }
    }
}
