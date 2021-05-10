using System;

namespace square
{
    class Program
    {
        static string error = "";
        static int squareSize;
        
        static void Main(string[] args)
        {
            do
            {
                if (error.Length > 0)
                {
                    Console.WriteLine(error);
                }
                promptUser();
            } while (error.Length > 0);

            for (int n = 0; n < squareSize; c++)
            {
                if (n + 1 == squareSize)
                {
                    Console.WriteLine(new string('*', (int)(squareSize * 1.8)));
                }
                else if (n > 0)
                {
                    Console.WriteLine(new string('*', 1) + new string(' ', (int)(squareSize * 1.8) - 2) + new string('*', 1));
                }
                else
                {
                    Console.WriteLine(new string('*', (int)(squareSize * 1.8)));
                }
            }
        }

        static void promptUser()
        {
            try
            {
                Console.WriteLine("Enter number of rows: ");
                squareSize = Convert.ToInt32(Console.ReadLine());

                if (squareSize > 0)
                {
                    error = "";
                }
                else
                {
                    error = "Please enter non negative whole numbers";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }
        }
    }
}
