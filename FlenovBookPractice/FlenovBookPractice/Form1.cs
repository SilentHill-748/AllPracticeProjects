using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Delegates;

namespace FlenovBookPractice
{
    public partial class Form1 : Form
    {
        Person pers = new Person();

        public Form1()
        {
            InitializeComponent();
            pers.AgeChange += AgeChange;
            pers.FirstNameChange += FirstNameChange;
            pers.SecondNameChange += SecondNameChange;
            pers.LastNameChange += LastNameChange;
        }

        private void LastNameChange(object sender, NameChangeArgs e)
        {
            Person p = (Person)sender;
            var mesResult = MessageBox.Show(
                $"Попытка изменить Отчество {p.LastName} на {e.NewName}", "Внимание");

            if (mesResult == DialogResult.Cancel)
                e.Canceled = true;
        }

        private void SecondNameChange(object sender, NameChangeArgs e)
        {
            Person p = (Person)sender;
            var mesResult = MessageBox.Show(
                $"Попытка изменить Фамилию {p.SecondName} на {e.NewName}", "Внимание");

            if (mesResult == DialogResult.Cancel)
                e.Canceled = true;
        }

        private void FirstNameChange(object sender, NameChangeArgs e)
        {
            Person p = (Person)sender;
            var mesResult = MessageBox.Show(
                $"Попытка изменить Имя {p.FirstName} на {e.NewName}", "Внимание");

            if (mesResult == DialogResult.Cancel)
                e.Canceled = true;
        }

        private void AgeChange(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            MessageBox.Show($"Возраст изменился на {numericUpDown1.Value}", "Внимание, пёс!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pers.Age = (int)numericUpDown1.Value;
            //pers.FirstName = firstNameTB.Text;
            //pers.LastName = lastNameTB.Text;
            //pers.SecondName = secNameTB.Text;
        }
    }
}
