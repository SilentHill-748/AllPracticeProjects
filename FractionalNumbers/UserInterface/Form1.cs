using System;
using FractionalLibrary;
using System.IO;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        private FractionalNumber[] fractionalNumbers;

        private FractionalNumber firstNumber;
        private FractionalNumber secondNumber;
        private FractionalNumber resultNumber;

        public Form1()
        {
            InitializeComponent();
            Text = "Простые дробные числа";
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (OperationComboBox.SelectedItem is null) throw new Exception("Не указана операция!");

                if (FirstNumberTextBox.Text == "") throw new Exception("Не введено первое число!");
                if (SecondNumberTextBox.Text == "") throw new Exception("Не введено второе число!");

                InitNumber(FirstNumberTextBox.Text, ref firstNumber);
                InitNumber(SecondNumberTextBox.Text, ref secondNumber);

                ResultLabel.Text = GetResultOperation(OperationComboBox.SelectedItem.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
                ResultLabel.Text = "Результат: ";
            }
        }

        private void ReductionButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ReductionNumberTextBox.Text == "") throw new Exception("Не введено число!");

                InitNumber(ReductionNumberTextBox.Text, ref resultNumber); 
                resultNumber.Reduction();
                ResultOfReductionLabel.Text = "Результат: " + resultNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
                ResultOfReductionLabel.Text = "Результат: ";
            }
        }

        private void ResultDegreeNumber_Click(object sender, EventArgs e)
        {
            try
            {
                if (ExponentiationTextBox.Text == "") throw new Exception("Не указано число!");
                if (DegreeTextBox.Text == "") throw new Exception("Не указано число степени!");

                InitNumber(ExponentiationTextBox.Text, ref resultNumber);
                if (int.TryParse(DegreeTextBox.Text, out int degreeNumber))
                    resultNumber = resultNumber.Exponentiation(degreeNumber);
                else
                    throw new Exception("Неверно задано число степени!");
                ResultOfExponentiationLabel.Text = "Результат: " + resultNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
                ResultOfExponentiationLabel.Text = "Результат: ";   
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                InitArray(ArrayNumsTextBox);
                Sort();
                SetArrayTextBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetSumButton_Click(object sender, EventArgs e)
        {
            try
            {
                InitArray(ArrayNumsTextBox);
                SumResultLabel.Text = "Сумма элементов: " + GetSumOfNumbers().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SumResultLabel.Text = "Сумма элементов: ";
                AvgResultLabel.Text = "Среднее элементов: ";
            }
        }

        private void GetAvgButton_Click(object sender, EventArgs e)
        {
            try
            {
                InitArray(ArrayNumsTextBox);
                AvgResultLabel.Text = "Среднее элементов: " + GetAvgOfNumbers().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                SumResultLabel.Text = "Сумма элементов: ";
                AvgResultLabel.Text = "Среднее элементов: ";
            }
        }

        private string GetResultOperation(string operation)
        {
            try
            {
                switch (operation)
                {
                    case "+": return "Результат: " + (firstNumber + secondNumber).ToString();
                    case "-": return "Результат: " + (firstNumber - secondNumber).ToString();
                    case "*": return "Результат: " + (firstNumber * secondNumber).ToString();
                    case "/": return "Результат: " + (firstNumber / secondNumber).ToString();
                    case ">": return "Результат: " + (firstNumber > secondNumber).ToString();
                    case "<": return "Результат: " + (firstNumber < secondNumber).ToString();
                    case ">=": return "Результат: " + (firstNumber >= secondNumber).ToString();
                    case "<=": return "Результат: " + (firstNumber <= secondNumber).ToString();
                    case "==": return "Результат: " + (firstNumber == secondNumber).ToString();
                    case "!=": return "Результат: " + (firstNumber != secondNumber).ToString();
                    default: return "Ошибка";
                }
            }
            catch
            {
                return "Результат: 0";
            }
        }

        private void InitArray(TextBox arrayTextBox)
        {
            if (arrayTextBox.Text == "") throw new Exception("Нет данных!");
            string[] inputs = arrayTextBox.Lines;
            fractionalNumbers = new FractionalNumber[inputs.Length];
            FractionalNumber temp = null;

            for (int i = 0; i < inputs.Length; i++)
                if (InitNumber(inputs[i], ref temp)) fractionalNumbers[i] = temp;
        }

        private void Sort()
        {
            FractionalNumber temp;
            for (int i = 0; i < fractionalNumbers.Length; i++)
            {
                for (int j = 0; j < fractionalNumbers.Length - 1; j++)
                {
                    if (fractionalNumbers[j].Number > fractionalNumbers[j+1].Number)
                    {
                        temp = fractionalNumbers[j];
                        fractionalNumbers[j] = fractionalNumbers[j + 1];
                        fractionalNumbers[j + 1] = temp;
                    }
                }
            }
        }

        private FractionalNumber GetSumOfNumbers()
        {
            FractionalNumber temp = fractionalNumbers[0];
                for (int i = 1; i < fractionalNumbers.Length; i++)
                    checked { temp += fractionalNumbers[i]; }
            return temp;
        }

        private FractionalNumber GetAvgOfNumbers()
        {
            FractionalNumber count = new FractionalNumber(fractionalNumbers.Length, 1);
            var temp = GetSumOfNumbers();

            return temp / count;
        }

        private void SetArrayTextBox()
        {
            string[] temp = new string[fractionalNumbers.Length];
            for (int i = 0; i < fractionalNumbers.Length; i++)
                temp[i] = fractionalNumbers[i].ToString();

            ArrayNumsTextBox.Lines = temp;
        }

        // Проверяет входные данные и в случае корректного ввода инициализирует новое число и возвращает true в случае успеха.
        private bool InitNumber(string numberTextBox, ref FractionalNumber number)
        {
            bool isCurrect = false;
            bool result;
            try
            {
                string[] strNumber = numberTextBox.Split('/');

                if (strNumber.Length != 2)
                    throw new Exception("Некорректный ввод дроби!");
                else if (!int.TryParse(strNumber[0], out int numerator))
                    throw new Exception("Некорректно задан числитель числа!");
                else if (!uint.TryParse(strNumber[1], out uint denominator))
                    throw new Exception("Некорректно задан знаминатель числа!");
                else if (strNumber[1].Contains("-") || strNumber[1] == "0")
                    throw new Exception("Знаменатель не может быть меньше или равен 0!");

                number = new FractionalNumber(int.Parse(strNumber[0]), uint.Parse(strNumber[1]));
                isCurrect = true; // Если проверки пройдены - вернем true.
            }
            finally
            {
                if (!isCurrect) number = null; 
                result = isCurrect;
            }
            return result;
        }

        private void CleanButton_Click(object sender, EventArgs e)
        {
            FirstNumberTextBox.Text = "";
            SecondNumberTextBox.Text = "";
            OperationComboBox.SelectedIndex = -1;
            ExponentiationTextBox.Text = "";
            DegreeTextBox.Text = "";
            ReductionNumberTextBox.Text = "";
            ArrayNumsTextBox.Text = "";

            ResultLabel.Text = "Результат: ";
            ResultOfExponentiationLabel.Text = "Результат: ";
            ResultOfReductionLabel.Text = "Результат: ";
            SumResultLabel.Text = "Сумма элементов: ";
            AvgResultLabel.Text = "Среднее элементов: ";
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader reader = new StreamReader(@"D:\Справка.txt"))
                {
                    MessageBox.Show(reader.ReadToEnd(), "Справка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
            }
        }
    }
}
