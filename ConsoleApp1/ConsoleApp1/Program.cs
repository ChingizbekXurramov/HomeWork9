namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write($"Enter Row number: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"Enter Columin number: ");
            int col = int.Parse(Console.ReadLine());
            int[][] arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(1, 100);
                    Console.Write($" {arr[i][j]}");
                }
                Console.WriteLine();
            }
            int rowMAX = arr[0][0];
            int colMIN = arr[0][0];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (rowMAX < arr[i][j])
                    {
                        rowMAX = arr[i][j];
                    }
                    if (colMIN > arr[i][j])
                    {
                        colMIN = arr[i][j];
                    }
                }
            }
            Console.WriteLine($"Max number: {rowMAX}");
            Console.WriteLine($"Min number: {colMIN}");
            Main(args);
        }
    }
}