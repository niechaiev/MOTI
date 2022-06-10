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
    public partial class Relation : Form
    {
        int firstAlt;
        int secondAlt;
        int idLPR;
        int rowInd;
        int colInd;
        public Relation(int fa, int sa, int id, int ri, int ci)
        {
            firstAlt = fa;
            secondAlt = sa;
            idLPR = id;
            rowInd = ri;
            colInd = ci;

            InitializeComponent();

            dataGridView1.Columns.Add("CName", "Критерии");

            foreach (DataRow row in alternativeTableAdapter.GetData())
            {
                if (Convert.ToInt32(row["ANum"]) == firstAlt)
                {
                    dataGridView1.Columns.Add(row["ANum"].ToString(), row["AName"].ToString());
                    label2.Text = row["AName"].ToString();
                }
            }

            foreach (DataRow row in alternativeTableAdapter.GetData())
            {
                if (Convert.ToInt32(row["ANum"]) == secondAlt)
                {
                    dataGridView1.Columns.Add(row["ANum"].ToString(), row["AName"].ToString());
                    label3.Text = row["AName"].ToString();
                }
            }

            foreach (DataRow row in criterionTableAdapter.GetData())
            {
                dataGridView1.Rows.Add(row["CName"].ToString());
            }

            foreach (DataRow row in alternative_information_QueryTableAdapter.GetDataBy(firstAlt, secondAlt))
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == row["CName"].ToString())
                    {
                        dataGridView1.Rows[i].Cells[row["ANum"].ToString()].Value = row["MName"].ToString() + " " + row["Unit"].ToString();
                        break;
                    }
                }


            }
        }

        private void Relation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Alternative_information_Query". При необходимости она может быть перемещена или удалена.
            this.alternative_information_QueryTableAdapter.Fill(this.database1DataSet.Alternative_information_Query);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Alternative". При необходимости она может быть перемещена или удалена.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet.Criterion". При необходимости она может быть перемещена или удалена.
            this.criterionTableAdapter.Fill(this.database1DataSet.Criterion);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database1DataSet._Relations". При необходимости она может быть перемещена или удалена.
            this.relationsTableAdapter.Fill(this.database1DataSet._Relations);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double rel = 0.5;
            if (radioButton1.Checked)
            {
                rel = 1;
            }
            else if (radioButton2.Checked)
            {
                rel = 0;
            }

            if (colInd - rowInd > 1)
            {
                relationsTableAdapter.DeleteExistingRel(idLPR, firstAlt, secondAlt);
                relationsTableAdapter.InsertQuery(idLPR, firstAlt, secondAlt, Convert.ToDecimal(rel));
            }
            else if (colInd - rowInd < 1)
            {
                relationsTableAdapter.DeleteExistingRel(idLPR, secondAlt, firstAlt);
                relationsTableAdapter.InsertQuery(idLPR, secondAlt, firstAlt, 1 - Convert.ToDecimal(rel));
            }
            this.Close();
        }
    }
}
