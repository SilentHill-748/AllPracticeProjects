using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ExamProject
{
    public partial class Form1 : Form
    {
        private string currentOperation = "";
        private RomeNumerics firstNum;
        private RomeNumerics secondNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (sender is Button but)
            {
                InputTextBox.Text += but.Text;
            }
        }

        private void Operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Operations.SelectedIndex == -1) return;

            if (string.IsNullOrWhiteSpace(InputTextBox.Text))
            {
                Operations.SelectedIndex = -1;
                return;
            }

            currentOperation = Operations.SelectedItem.ToString();
            if (currentOperation != "")
                InputTextBox.Text += currentOperation;
            Operations.SelectedIndex = -1;

            this.Focus();
        }

        private void ResultBut_Click(object sender, EventArgs e)
        {
            try
            {
                string pattern = $@"[^{currentOperation}]*";
                var matches = Regex.Matches(InputTextBox.Text, pattern);

                firstNum = new RomeNumerics(matches[0].Value);
                secondNum = new RomeNumerics(matches[2].Value);

                string result = GetResult(currentOperation);
                InputTextBox.Text = "";
                ResultTextBox.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
                return;
            }
        }

        private string GetResult(string operation)
        {
            switch (operation)
            {
                case "+": return (firstNum + secondNum).Value;
                case "-": return (firstNum - secondNum).Value;
                case "*": return (firstNum * secondNum).Value;
                case "/": return (firstNum / secondNum).Value;
                case "%": return (firstNum % secondNum).Value;
                case ">": return (firstNum > secondNum).ToString();
                case "<": return (firstNum < secondNum).ToString();
                case ">=": return (firstNum >= secondNum).ToString();
                case "<=": return (firstNum <= secondNum).ToString();
                case "==": return (firstNum == secondNum).ToString();
                case "!=": return (firstNum != secondNum).ToString();
                default:
                    throw new Exception("Операция не поддерживается или не выбрана операция!");
            }
        }

        private void InputTextBox_TextChanged(object sender, EventArgs e)
        {
            string text = InputTextBox.Text;
            if (!text.EndsWith(currentOperation))
                ResultBut.Enabled = true;
            else
                ResultBut.Enabled = false;
        }

        private void Clean_Click(object sender, EventArgs e)
        {
            InputTextBox.Text = "";
            ResultTextBox.Text = "";
            ResultBut.Enabled = false;
            Operations.Enabled = true;
            isSelectedOperation = false;
        }

        private void SortBut_Click(object sender, EventArgs e)
        {
            try
            {
                var array = InitArray(InputArray.Text);
                var sortedArray = array.OrderBy(num => num.IntValue);

                var intResult = sortedArray.Select(num => num.IntValue).ToArray();
                var romeResult = sortedArray.Select(num => num.Value).ToArray();

                SortRomeResult.Text = string.Join(" ", romeResult);
                SortIntResult.Text = string.Join(" ", intResult);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание!");
                return;
            }
        }

        private void FindExists_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(InputRomeNumbers.Text))
                    throw new Exception();

                if (string.IsNullOrWhiteSpace(InputIntNumbers.Text))
                    throw new Exception();

                var romeNums = InitArray(InputRomeNumbers.Text);
                var intNums = InputIntNumbers.Text.Split(' ', ',').
                    Select(i => int.Parse(i.Trim())).ToArray();

                var result = FindExistsBetweenArraies(intNums, romeNums);
                ResultFindedRomeNums.Text = result[0];
                ResultFindedIntNums.Text = result[1];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание");
                return;
            }
        }

        private void CleanSortArgs_Click(object sender, EventArgs e)
        {
            InputArray.Text = "";
            SortIntResult.Text = "";
            SortRomeResult.Text = "";
        }

        private void CleanFindArgs_Click(object sender, EventArgs e)
        {
            InputIntNumbers.Text = "";
            InputRomeNumbers.Text = "";

            ResultFindedIntNums.Text = "";
            ResultFindedRomeNums.Text = "";
        }

        private RomeNumerics[] InitArray(string inputLine)
        {
            string[] stringRomeNums = inputLine.Split(' ', ',').Select(s => s.Trim()).ToArray();
            var resultList = new List<RomeNumerics>();
            for (int i = 0; i < stringRomeNums.Length; i++)
            {
                var num = new RomeNumerics(stringRomeNums[i]);
                resultList.Add(num);
            }
            return resultList.ToArray();
        }

        // Найдет и выведет массив из 2 строк, содержащие найденные числа в 2 форматах.
        private string[] FindExistsBetweenArraies(int[] intArray, RomeNumerics[] romeArray)
        {
            var resultList = new List<RomeNumerics>();

            for (int i = 0; i < intArray.Length; i++)
            {
                for (int j = 0; j < romeArray.Length; j++)
                {
                    int num = romeArray[j].IntValue;
                    if (num == intArray[i])
                    {
                        if (resultList.Contains(romeArray[j]))
                            continue;

                        resultList.Add(romeArray[j]);
                        break;
                    }
                }
            }
            string intResult = IntToString(resultList);
            string romeResult = RomeToString(resultList);

            return new string[] { intResult, romeResult };
        }

        private string IntToString(List<RomeNumerics> findedNums)
        {
            string result = "";
            foreach (var num in findedNums)
                result += $"{num.IntValue} ";
            return result;
        }

        private string RomeToString(List<RomeNumerics> findedNums)
        {
            string result = "";
            foreach (var num in findedNums)
                result += $"{num.Value} ";
            return result;
        }
    }
}