using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StripComments_Windows_Form_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SCForm newStripComments = new SCForm();
            newStripComments.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FromDataBase newFromDataBase = new FromDataBase();
            newFromDataBase.Show();
        }

    }
}
