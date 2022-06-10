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
    public partial class kondorceForm : Form
    {

        public kondorceForm()
        {
            InitializeComponent();


            foreach (DataRow LPR in lPRTableAdapter.GetData())
            {
                grid.Columns.Add(LPR["LNum"].ToString(), LPR["LName"].ToString());
            }
            foreach (DataRow alt in alternativeTableAdapter.GetData())
            {
                grid.Rows.Add();
            }
            foreach (DataGridViewColumn clm in grid.Columns)
            {
                int i = 0;
                foreach (DataRow alt in resusltViewTableAdapter.GetDataBy(Convert.ToInt32(clm.Name)).OrderBy(x => x.Rank).ThenByDescending(x => x.AWeight))
                {
                    grid[clm.Name, i++].Value = alt["AName"];
                }
            }


            
        }

        private void koplandForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Alternative' table. You can move, or remove it, as needed.
            this.alternativeTableAdapter.Fill(this.database1DataSet.Alternative);
            // TODO: This line of code loads data into the 'database1DataSet.LPR' table. You can move, or remove it, as needed.
            this.lPRTableAdapter.Fill(this.database1DataSet.LPR);
            // TODO: This line of code loads data into the 'database1DataSet.ResusltView' table. You can move, or remove it, as needed.
            this.resusltViewTableAdapter.Fill(this.database1DataSet.ResusltView);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;

            foreach (DataRow alt in alternativeTableAdapter.GetData())
            {

                bool skip = false;
                int count = 0;

                int first = 0;
                int second = 0;
                foreach (DataRow alt2 in alternativeTableAdapter.GetData())
                {
                    count++;
                    if (skip) break;

                    if (alt["ANum"].ToString() == alt2["ANum"].ToString()) continue;

                    first = 0;
                    second = 0;

                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (grid[column.Name, 0].Value == null)
                            continue;

                        for (int i = 0; i < grid.RowCount; i++)
                        {
                            if (grid[column.Name, i].Value.ToString() == alt["AName"].ToString())
                            {
                                first++;
                                break;
                            }
                            else if (grid[column.Name, i].Value.ToString() == alt2["AName"].ToString())
                            {
                                second++;
                                break;
                            }
                        }
                    }
                    richTextBox1.Text += alt["AName"];
                    if (first > second)
                        richTextBox1.Text += " > ";
                    else if (first < second)
                        richTextBox1.Text += " < ";
                    else richTextBox1.Text += " = ";
                    richTextBox1.Text += alt2["AName"] + " = " + first + ":" + second + "\n";

                    if (first < second) skip = true;

                }

                if (count == alternativeTableAdapter.GetData().Count)
                {
                    if (first > second)
                    {

                        richTextBox1.Text += "\n" + alt["AName"] + " won";
                        checkEmptyResults();
                        return;

                    }
     
                }
            }

            checkEmptyResults();
            richTextBox1.Text += "\n404 winner not found";
        }

        private void checkEmptyResults()
        {
            string names = String.Empty;
            for(int i = 0; i < grid.ColumnCount; i++)
            {
                if(grid[i,0].Value == null)
                {
                    names += grid.Columns[i].HeaderText + ", ";
                }
            }
            if(names != string.Empty)
                MessageBox.Show(names.Remove(names.Length - 2,1) + "не входят в сравнение");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
            DataTable alternatives = alternativeTableAdapter.GetData();
            double[] points = new double[alternatives.Rows.Count];
            for(int i =0;i<alternatives.Rows.Count;i++)
            {
                DataRow alt = alternatives.Rows[i];
                int count = 0;

                int first = 0;
                int second = 0;
                for(int j=i+1; j < alternatives.Rows.Count; j++) {
                    DataRow alt2 = alternatives.Rows[j];
                    count++;

                    if (alt["ANum"].ToString() == alt2["ANum"].ToString()) continue;

                    first = 0;
                    second = 0;

                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (grid[column.Name, 0].Value == null)
                        {
                            continue;
                        }
                        for (int k = 0; k < grid.RowCount; k++)
                        {
                            if (grid[column.Name, k].Value.ToString() == alt["AName"].ToString())
                            {
                                first++;
                                break;
                            }
                            else if (grid[column.Name, k].Value.ToString() == alt2["AName"].ToString())
                            {
                                second++;
                                break;
                            }
                        }
                    }
                    richTextBox1.Text += alt["AName"];
                    if (first > second)
                    {
                        points[i]++;
                        points[j]--;
                        richTextBox1.Text += " > ";
                    }
                    else if (first < second)
                    {
                        points[i]--;
                        points[j]++;
                        richTextBox1.Text += " < ";
                    }
                    else
                    {
                        richTextBox1.Text += " = ";
                    }

                    richTextBox1.Text += alt2["AName"] + " = " + first + ":" + second + "\n";

                }
            }
            for(int i = 0; i < alternatives.Rows.Count; i++) { 
                richTextBox1.Text += "\nОчки (" + alternatives.Rows[i]["AName"] + ") = " + points[i];
                if (points[i] == points.Max()) richTextBox1.Text += " -- WINNER!";
            }
            checkEmptyResults();
        }
    }
}
