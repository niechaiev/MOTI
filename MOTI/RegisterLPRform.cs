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
    public partial class RegisterLPRform : Form
    {
        public RegisterLPRform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lPRTableAdapter.Insert(textBox1.Text, Convert.ToInt32(textBox2.Text));
            Close();
        }

        private void RegisterLPRform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.LPR' table. You can move, or remove it, as needed.
            this.lPRTableAdapter.Fill(this.database1DataSet.LPR);

        }
    }
}
