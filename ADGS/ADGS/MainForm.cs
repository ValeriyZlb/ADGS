﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ADGS
{ 
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MenuItem_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Automatic data get system v 0.1", "ADGS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
