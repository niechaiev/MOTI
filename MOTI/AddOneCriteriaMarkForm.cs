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
    public partial class AddOneCriteriaMarkForm : Form
    {
        int ANum;
        public AddOneCriteriaMarkForm(List<int> CNums, int ANum)
        {
            InitializeComponent();
            this.ANum = ANum;
            comboBox1.DisplayMember = "CName";
            comboBox1.ValueMember = "CNum";
            comboBox2.DisplayMember = "MName";
            comboBox2.ValueMember = "MNum";

            foreach (DataRow row in criterionTableAdapter.GetData().Rows)
            {
                if (CNums.Contains(Convert.ToInt32(row["CNum"])))
                {
                    comboBox1.Items.Add(row);
                }
            }
            comboBox1.SelectedItem = comboBox1.Items[0];

        }

        private void AddOneCriteriaMarkForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Vector' table. You can move, or remove it, as needed.
            this.vectorTableAdapter.Fill(this.database1DataSet.Vector);
            // TODO: This line of code loads data into the 'database1DataSet.Criterion' table. You can move, or remove it, as needed.
            this.criterionTableAdapter.Fill(this.database1DataSet.Criterion);

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedItem != null)
            {
                
                comboBox2.DataSource = markTableAdapter.GetDataByCNum(Convert.ToInt32(((sender as ComboBox).SelectedItem as DataRow)["CNum"]));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vectorTableAdapter.InsertQuery(ANum, Convert.ToInt32(comboBox2.SelectedValue));
            Close();
        }
    }
}
