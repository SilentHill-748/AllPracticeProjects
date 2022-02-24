using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                DataRow nRow = main.innn11DataSet.Tables[0].NewRow();
                int rc = main.dataGridView1.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = tbid.Text;
                nRow[2] = tbимя.Text;
                nRow[3] = tbфамилия.Text;
                nRow[4] = tbдата.Text;
              
                main.innn11DataSet.Tables[0].Rows.Add(nRow);
                main.тестTableAdapter.Update(main.innn11DataSet.тест);
                main.innn11DataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                tbid.Text = "";
                tbимя.Text = "";
                tbфамилия.Text = "";
                tbотчество.Text = "";
                tbдата.Text = "";
                tbадрес.Text = "";
            }
        }
    }
}
