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
    public partial class AlternativeCreationForm : Form
    {
        public AlternativeCreationForm()
        {
            InitializeComponent();

        }

        private void AlternativeCreationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.MarkCriteriaView' table. You can move, or remove it, as needed.
            this.markCriteriaViewTableAdapter.Fill(this.database1DataSet.MarkCriteriaView);
            this.criterionTableAdapter1.Fill(this.database1DataSet.Criterion);

            int i = 0;
            foreach (DataRow row in database1DataSet.Criterion.Rows)
            {
                dataGridView1.Rows.Add(row["CName"], row["CNum"]);

                DataGridViewComboBoxCell cmb = new DataGridViewComboBoxCell();
                DataTable table =  markCriteriaViewTableAdapter.GetDataBy(Convert.ToInt32(row["CNum"]));
                cmb.DataSource = table;
                if(table.Rows.Count > 0)
                    cmb.Value = table.Rows[0]["MNum"];
                cmb.ValueMember = "MNum";
                cmb.DisplayMember = "MName";
                cmb.ReadOnly = false;
                dataGridView1.Rows[i++].Cells[2]= cmb;
                

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            alternativeTableAdapter1.InsertQuery(textBox1.Text);
            int ANum = Convert.ToInt32(alternativeTableAdapter1.selectByName(textBox1.Text).Rows[0]["ANum"]);
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                vectorTableAdapter1.Insert(ANum, Convert.ToInt32(row.Cells[2].Value));
            }

            SUCCess form = new SUCCess("Альтернатива добавлена");
            form.ShowDialog();
            Close();
           
        }
    }
}
