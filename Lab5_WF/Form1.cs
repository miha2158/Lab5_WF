using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab5;

namespace Lab5_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static int[] arr1D = new int[0];
        private static int[,] arr2D = new int[0,0];
        private static int[][] arrJ = new int[0][];
        private static int[][] tempInts = null;

        private static readonly string[] Actions =
        {
            "Дейсвтие: Добавить элемент в конец массива",
            "Дейсвтие: Удалить столбец",
            "Дейсвтие: Добавть строки в конец массива"
        };

        private static readonly string[] Arrays =
        {
            "Одномерный массив",
            "Двумерный массив",
            "Рваный массив"
        };
        
        private static int arrayType;



        private void startB_1Dim_Click(object sender, EventArgs e)
        {
            CreateButton.Visible = true;
            DoCreateButton.Visible = false;
            RandFillButton.Visible = false;
            RFButton.Visible = false;
            ActionButton.Visible = false;
            DoActionButton.Visible = false;
            textBox.ReadOnly = true;
            taskBox.Visible = false;

            if (arr1D.Length > 0)
            {
                ActionName.Visible = true;
                textBox.Text = Tasks.ArrayToString(arr1D);
                ActionButton.Visible = true;
            }
            else
            {
                ActionName.Visible = false;
                textBox.Clear();
            }
            arrayType = 0;
            ActionName.Text = Actions[arrayType];

        }

        private void startB_2Dim_Click(object sender, EventArgs e)
        {
            CreateButton.Visible = true;
            DoCreateButton.Visible = false;
            RandFillButton.Visible = false;
            RFButton.Visible = false;
            DoActionButton.Visible = false;
            textBox.ReadOnly = true;
            taskBox.Visible = false;

            if (arr2D.Length > 0)
            {
                ActionName.Visible = true;
                ActionButton.Visible = true;
                textBox.Text = Tasks.ArrayToString(arr2D);
            }
            else
            {
                ActionName.Visible = false;
                ActionButton.Visible = false;
                textBox.Clear();
            }
            arrayType = 1;
            ActionName.Text = Actions[arrayType];

        }

        private void startB_Jagged_Click(object sender, EventArgs e)
        {
            CreateButton.Visible = true;
            DoCreateButton.Visible = false;
            RandFillButton.Visible = false;
            RFButton.Visible = false;
            DoActionButton.Visible = false;
            textBox.ReadOnly = true;
            taskBox.Visible = false;

            if (arrJ.Length > 0)
            {
                ActionName.Visible = true;
                ActionButton.Visible = true;
                textBox.Text = Tasks.ArrayToString(arrJ);
            }
            else
            {
                ActionName.Visible = false;
                ActionButton.Visible = false;
                textBox.Clear();
            }
            arrayType = 2;
            ActionName.Text = Actions[arrayType];
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            taskBox.Visible = false;
            taskBox.Clear();
            DoActionButton.Visible = false;
            RFButton.Visible = false;
            textBox.ReadOnly  = false;
            DoCreateButton.Visible = true;
            RandFillButton.Visible = true;

            ActionName.Text = Arrays[arrayType];
            ActionName.Visible = true;
        }

        private void RandFillButton_Click(object sender, EventArgs e)
        {
            DoCreateButton.Visible = false;
            RandFillButton.Visible = false;

            switch (arrayType)
            {
                case 0:
                    arr1D = null;
                    Tasks.Randomise(ref arr1D);
                    startB_1Dim_Click(sender, e);
                    break;
                case 1:
                    arr2D = null;
                    Tasks.Randomise(ref arr2D);
                    startB_2Dim_Click(sender, e);
                    break;
                case 2:
                    arrJ = null;
                    Tasks.Randomise(ref arrJ);
                    startB_Jagged_Click(sender, e);
                    break;
            }
        }

        private void RFButton_Click(object sender, EventArgs e)
        {
            Tasks.Randomise(ref tempInts);
            taskBox.Text = Tasks.ArrayToString(tempInts);
            tempInts = null;
        }

        private void DoCreateButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Любой неправильно введённый символ будет заменён на 0","Понтно?");
            DoCreateButton.Visible = false;
            RandFillButton.Visible = false;
            if (arrayType != 0)
            {
                string[] input = textBox.Text.Split('\n');
                for (int i = 0; i < input.Length; i++)
                    input[i] = input[i].Trim().Replace("  ", " ");
                int[][] temp = Tasks.StringToArray(input);

                if (arrayType == 1)
                {
                    arr2D = Tasks.JaggedTo2D(temp);
                    startB_2Dim_Click(sender, e);
                }
                else
                {
                    arrJ = temp;
                    startB_Jagged_Click(sender, e);
                }
            }
            else
            {
                arr1D = Tasks.StringToArray(textBox.Text.Replace("\n", " ").Replace("  ", " "));
                startB_1Dim_Click(sender, e);
            }
            ActionButton.Focus();
            textBox.ReadOnly  = true;
        }

        private void ActionButton_Click(object sender, EventArgs e)
        {
            DoActionButton.Visible = true;
            taskBox.Clear();
            taskBox.Visible = true;
            taskBox.Focus();
            if (arrayType == 2)
                RFButton.Visible = true;
        }

        private void DoActionButton_Click(object sender, EventArgs e)
        {
            taskBox.Visible = false;
            int p = 0;
            switch (arrayType)
            {
                case 0:
                    int.TryParse(taskBox.Text, out p);
                    arr1D = Tasks.Extend1Dim(arr1D, p);
                    startB_1Dim_Click(sender,e);
                    break;
                case 1:
                    int.TryParse(taskBox.Text, out p);
                    p--;
                    if (p >= 0 && p < arr2D.GetLength(1))
                        arr2D = Tasks.Shrink2Dim(arr2D, p);
                    else MessageBox.Show("Нельзя удалить столбец вне массива", "ОК?");
                    ActionButton.Focus();
                    startB_2Dim_Click(sender, e);
                    break;
                case 2:
                {
                    string[] input = taskBox.Text.Split('\n');
                    for (int i = 0; i < input.Length; i++)
                        input[i] = input[i].Trim().Replace("  ", " ");
                    tempInts = Tasks.StringToArray(input);

                    arrJ = Tasks.ExtendJagged(arrJ, tempInts);
                    startB_Jagged_Click(sender, e);
                }
                    break;
            }
            taskBox.Clear();
            RFButton.Visible = false;
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            int point = textBox.SelectionStart;

            if (textBox.Text != string.Empty)
                if (textBox.Text[0] != ' ')
                {
                    textBox.Text = ' ' + textBox.Text;
                    point++;
                }
                else
                {
                    string output = String.Empty;
                    for (int i = 0; i < textBox.TextLength; i++)
                    {
                        char place = textBox.Text[i];
                        if (char.IsDigit(place) || char.IsWhiteSpace(place))
                            output = output + place;
                        else if (place == '-' && textBox.Text[i - 1] == ' ')
                            output = output + place;
                        else point--;
                        output = output.Replace("--", "");
                    }
                    textBox.Text = output;
                }

            textBox.SelectionStart = point;
        }

        private void taskBox_TextChanged(object sender, EventArgs e)
        {
            int point = taskBox.SelectionStart; 

            if (taskBox.Text != string.Empty)
                if (taskBox.Text[0] != ' ')
                {
                    taskBox.Text = ' ' + taskBox.Text;
                    point++;
                }
                else
                {
                    string output = String.Empty;
                    for (int i = 0; i < taskBox.TextLength; i++)
                    {
                        char place = taskBox.Text[i];
                        if (char.IsDigit(place) || char.IsWhiteSpace(place) || place == '-')
                            output = output + place;
                        else point--;
                        output = output.Replace("--", "");
                    }
                    taskBox.Text = output;
                }
            taskBox.SelectionStart = point;
        }
    }
}