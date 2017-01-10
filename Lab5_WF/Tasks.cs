using System;

namespace Lab5
{
    public class Tasks
    {
        #region tasks

        public static int[][] ExtendJagged(int[][] array, int[][] newStuff)
        {
            int[][] temp = new int[array.Length + newStuff.Length][];

            for (int i = 0; i < array.Length; i++)
                temp[i] = array[i];
            for (int i = 0; i < newStuff.Length; i++)
                temp[i + array.Length] = newStuff[i];

            return temp;
        }

        public static int[] Extend1Dim(int[] array, int element)
        {
            int[] temp = new int[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                temp[i] = array[i];
            temp[temp.Length - 1] = element;

            return temp;
        }

        public static int[,] Shrink2Dim(int[,] array, int column)
        {
            int l0 = array.GetLength(0);
            int l1 = array.GetLength(1) - 1;



            int[,] temp = new int[l0, l1];

            for (int i0 = 0; i0 < l0; i0++)
                for (int i1 = 0, j1 = 0; i1 < l1; i1++, j1++)
                {
                    if (i1 == column)
                        j1++;
                    temp[i0, i1] = array[i0, j1];
                }

            return temp;
        }

        #endregion

        #region randomise

        static readonly Random Rand = new Random();
        private const int RMin = -99;
        private const int RMax = 99;
        private const int ReasonableSize = 13;

        public static void Randomise(ref int[] array)
        {
            if (array == null)
                array = new int[Rand.Next(ReasonableSize) + 1];

            for (int i = 0; i < array.Length; i++)
                array[i] = Rand.Next(RMin, RMax + 1);
        }

        public static void Randomise(ref int[][] array)
        {
            if (array == null)
                array = new int[Rand.Next(ReasonableSize) + 1][];

            for (int i = 0; i < array.Length; i++)
            {
                Randomise(ref array[i]);
            }
        }

        public static void Randomise(ref int[,] array)
        {
            if (array == null)
                array = new int[Rand.Next(ReasonableSize) + 1, Rand.Next(ReasonableSize) + 1];

            int l1 = array.GetLength(0);
            int l2 = array.GetLength(1);

            for (int i0 = 0; i0 < l1; i0++)
                for (int i1 = 0; i1 < l2; i1++)
                    array[i0, i1] = Rand.Next(RMin, RMax + 1);
        }

        #endregion

        #region input

        public static int[] StringToArray(string input)
        {
            int[] result = new int[0];
            input = input.Replace("  ", " ");

            string[] temp = input.Split(' ');

            for (int i = 0,j = 0; i < temp.Length; i++)
            {
                int temp1 = 0;
                if (temp[i].Trim() != string.Empty && int.TryParse(temp[i], out temp1) || temp[i].Trim() == "-")
                {
                    int[] array = new int[result.Length + 1];
                    result.CopyTo(array, 0);
                    array[j++] = temp1;
                    result = array;
                }

            }
            return result;
        }

        public static int[][] StringToArray(string[] input)
        {
            int[][] array = new int[0][];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != string.Empty)
                {
                    int[][] temp = new int[array.Length + 1][];
                    array.CopyTo(temp, 0);
                    temp[i] = StringToArray(input[i]);
                    array = temp;
                }
            }
            return array;
        }

        public static int[,] JaggedTo2D(int[][] array)
        {
            int width = array[0].Length;
            for (int i = 1; i < array.Length; i++)
                if (array[i].Length > width)
                    width = array[i].Length;

            int[,] result = new int[array.Length, width];
            for (int i0 = 0; i0 < array.Length; i0++)
                for (int i1 = 0; i1 < width; i1++)
                    try
                    {
                        result[i0, i1] = array[i0][i1];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        result[i0, i1] = 0;
                    }
            return result;
        }

        #endregion

        #region output

        public const string OutputFormat = "{0} {1,4}";

        public static string ArrayToString(int[] array)
        {
            string output = String.Empty;
            if (array.Length == 0)
                output = " Пустой массив";
            else
                foreach (int item in array)
                    output = String.Format(OutputFormat, output, item);
            output = output + "\r\n";

            return output;
        }

        public static string ArrayToString(int[][] array)
        {
            string output = String.Empty;

            if (array.Length == 0)
                output = " Пустой массив\n";
            else
                foreach (var item in array)
                {
                    output = output + ArrayToString(item);
                }
            return output;
        }

        public static string ArrayToString(int[,] array)
        {
            string output = String.Empty;

            if (array.GetLength(0) == 0 || array.GetLength(1) == 0)
                output = " Пустой Массив\n";
            else
                for (int i0 = 0; i0 < array.GetLength(0); i0++)
                {
                    for (int i1 = 0; i1 < array.GetLength(1); i1++)
                        output = String.Format(OutputFormat, output, array[i0, i1]);
                    output = output + "\r\n";
                }

            return output;
        }

        #endregion

    }
}