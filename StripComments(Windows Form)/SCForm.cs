using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace StripComments_Windows_Form_
{
    public partial class SCForm : Form
    {
        DataContext db;
        public SCForm()
        {
            InitializeComponent();
            db = new DataContext();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            OutputText.Text = Algorithm.StripComments(InputText.Text, CommentSymbol.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data data = new Data();

            data.InputText = InputText.Text;
            data.CommentSymbol = CommentSymbol.Text;
            data.OutputText = OutputText.Text;
            db.Datas.Add(data);
            db.SaveChanges();
            MessageBox.Show("Successful");

        }
    }
}
