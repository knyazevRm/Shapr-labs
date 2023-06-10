/*
 * №12
 * Упорядочить строки матрицы A(m, n) по неубыванию суммы элементов строк.
*/

namespace ConsoleApplication
{
    class Matrix
    {
        private int rows;
        private int cols;
        private double[,] matrix;

        public int Rows
        {
            get
            {
                return rows;
            }
        }
        
        public int Cols
        {
            get
            {
                return cols;
            }
        }
        
        public double[,] Mat
        {
            get
            {
                return matrix;
            }
        }
        
        public void SortBySumOfRow()
        {
            double[] sumOfEachRows = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                sumOfEachRows[i] = SumOfRow(i);
            }
            
            SelectionSort(sumOfEachRows);
        }
        
        static int IndexOfMin(double[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }

            return result;
        }
        
        private double[] SelectionSort(double[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;

            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                SwapTwoElem(ref array[index], ref array[currentIndex]);
                SwapRows(index, currentIndex);
            }
            
            return SelectionSort(array, currentIndex + 1);
        }
        
        private void SwapRows(int firstIndex, int secIndex)
        {
            for (int j = 0; j < cols; j++)
            {
                (matrix[firstIndex, j], matrix[secIndex, j]) = (matrix[secIndex, j], matrix[firstIndex, j]);
            }
        }

        private void SwapTwoElem(ref double x, ref double y)
        {
            (x, y) = (y, x);
        }

        private double SumOfRow(int indexOfRow)
        {
            double sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += matrix[indexOfRow, j];
            }
            return sum;
        }
        public void PrintMatrix(string header)
        {
            Console.WriteLine(header);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write("\t" + matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrix = new double[rows, cols];
        }

        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
            this.rows = matrix.GetLength(0);
            this.cols = matrix.GetLength(1);
        }
    }
    
    class SortSumOfRow
 {
     static void PrintString(string header, int i, int j)
     {
         Console.Write(header + "[" + i.ToString() + "][" + j.ToString() + "] = ");
     }

     static void FillDataInMatrix(double[,] matrix, int rows, int cols)
     {
         for (int i = 0; i < rows; i++)
         {
             for (int j = 0; j < cols; j++)
             {
                 PrintString("matrix", i, j);
                 matrix[i, j] = Convert.ToDouble(Console.ReadLine());
             }
         }
     }

     static void Main()
     {
         Console.Write("Input num of rows: ");
         int rows = Convert.ToInt32(Console.ReadLine());
         Console.Write("Input num of columns: ");
         int cols = Convert.ToInt32(Console.ReadLine());

         Matrix matrix = new Matrix(rows, cols);

         FillDataInMatrix(matrix.Mat, rows, cols);
         
         matrix.PrintMatrix("Initial matrix");
         
         matrix.SortBySumOfRow();

         matrix.PrintMatrix("Matrix sort by sum of rows");
     }
 }
}