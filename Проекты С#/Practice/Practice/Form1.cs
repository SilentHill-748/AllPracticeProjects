using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form1 : Form
    {
        Auto[] carCollection = new Auto[1000];
        int countCars, countLoadCars;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitObjects();
            groupBox1.Visible = false;
            inputTextBox.KeyPress += inputTextBox_KeyPress;
            listBox1.DoubleClick += ListBox1_DoubleClick;
            delButton.Enabled = false;
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            if( listBox1.Items.Count != 0 ) // если список не пуст, то открыть данные выбранного элемента.
            {
                groupBox1.Visible = true;
                LoadInfo();
            }
            else
            {
                groupBox1.Visible = false;
                MessageBox.Show("Таблица пуста.");
            }
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter )
            {
                if (inputTextBox.Text != "")
                {
                    groupBox1.Visible = true;
                    numTextBox.Text = inputTextBox.Text;
                }
                else
                {
                    groupBox1.Visible = false;
                    MessageBox.Show("Данные не введены.");
                }
            }
        }

        private void InitObjects()
        {
            int i;
            countCars = 0;
            countLoadCars = 0;
            for ( i = 0; i < 1000; i++ )
                carCollection[i] = new Auto();
            
            Text = "lab 9";
            label1.Text = "Список номеров";
            groupBox1.Text = "Данные";
            label2.Text = "Гос. номер";
            label3.Text = "Модель";
            label4.Text = "Цвет";
            label5.Text = "ФИО\nвладельца";
            label6.Text = "Цвет";
            delButton.Text = "Удалить";
            saveButton.Text = "Сохранить";
            cancelSaveButton.Text = "Отменить сохранение";
            GetColorComboBox2();
            colorTextBox.Enabled = false;
        }

        private void GetColorComboBox2()
        {
            int i;
            for( i = 0; i < 6; i++ )
                comboBox2.Items.Add((CarColor)i);
        }

        private void LoadInfo()
        {
            string model, color, name;
            numTextBox.Text = listBox1.SelectedItem.ToString();
            carCollection[countLoadCars].GetInfo(out model, out color, out name);
            modTextBox.Text = model;
            colorTextBox.Text = color;
            nameTextBox.Text = name;
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (listBox1.Items.Count == 0)
                delButton.Enabled = false;
            groupBox1.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            colorTextBox.Text = comboBox2.Text;
        }

        private void cancelSaveButton_Click(object sender, EventArgs e) //отмена сохранения данных, очищаем поля и скрываем груп объект
        {
            CleanTextBoxes();
        }

        private void CleanTextBoxes()
        {
            numTextBox.Text = null;
            modTextBox.Text = null;
            colorTextBox.Text = null;
            comboBox2.Text = null;
            nameTextBox.Text = null;
            groupBox1.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            carCollection[countCars].SetInfo(numTextBox.Text, modTextBox.Text, colorTextBox.Text, nameTextBox.Text);
            SaveToListBox1();
            countCars++;
            inputTextBox.Text = null;
            CleanTextBoxes();
        }

        private void SaveToListBox1()
        {
            string numberCar;
            carCollection[countCars].GetNumAuto(out numberCar);
            listBox1.Items.Add(numberCar);
        }
    }

    public enum CarColor
    {
        Красный,
        Синий,
        Зеленый,
        Желтый,
        Серый,
        Черный
    }

    public class Auto
    {
        string model;
        string name;
        string number;
        string color;

        public Auto()
        {
            color = "";
            name = "";
            number = "";
            model = "";
        }

        public void SetInfo(string numberCar, string model, string color, string fio)
        {
            this.number = numberCar;
            this.model = model;
            this.color = color;
            this.name = fio;
        }

        public void GetNumAuto(out string number)
        {
            number = this.number;
        }

        public void GetInfo(out string model, out string color, out string name)
        {
            model = this.model;
            color = this.color;
            name = this.name;
        }
    }
}
