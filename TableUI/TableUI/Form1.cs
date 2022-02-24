using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TableUI
{
    public partial class Form1 : Form
    {
        private Table table;
        private Table selected;

        public Form1()
        {
            InitializeComponent();
            table = new Table();
            selected = new Table();
            Output(table, TableRTB);
            Output(selected, ResultTableRTB);
        }

        private void ByNumberRowMI_Click(object sender, EventArgs e)
        {
            table?.Sort("Номер");
            Output(table, TableRTB);
        }

        private void ByNumberPageMI_Click(object sender, EventArgs e)
        {
            table?.Sort("Номер страницы");
            Output(table, TableRTB);
        }

        private void ByNumberLineMI_Click(object sender, EventArgs e)
        {
            table?.Sort("Номер строки");
            Output(table, TableRTB);
        }

        private void ByTextEditMI_Click(object sender, EventArgs e)
        {
            table?.Sort("Текст изменения строки");
            Output(table, TableRTB);
        }

        private void ByDateMenuItem_Click(object sender, EventArgs e)
        {
            table?.Sort("Дата изменения");
            Output(table, TableRTB);
        }

        // Вывод таблицы в TableRTB
        private void Output(Table table, RichTextBox rtb)
        {
            rtb.Text = table.GetHeaders();
            string[] rows = table.GetRows();

            foreach (string row in rows)
                rtb.Text += row;
        }

        // Очистка и справка.
        private void ClearAllMenuItem_Click(object sender, EventArgs e)
        {
            table?.Clear();
            selected?.Clear();
            Output(table, TableRTB);
            Output(selected, ResultTableRTB);
        }

        private void HelpMenuStrip_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Справка.txt");
            }
            catch (Exception)
            {
                MessageBox.Show("Файл справки не найден!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperationMenuStrip_Click(object sender, EventArgs e)
        {
            try
            {
                OperationsForm form = new OperationsForm(table);
                form.ShowDialog();

                if (form.Error) return;

                table = form.EditedTable;
                selected = form.SelectedTable;

                Output(table, TableRTB);
                Output(selected, ResultTableRTB);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}