﻿using System;
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
    public partial class SUCCess : Form
    {
        public SUCCess(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void SUCCess_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
