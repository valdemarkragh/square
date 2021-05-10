using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace square
{
    class Program
    {
        static string error = "";
        static int rows;
        static int columns;
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

            for (int c = 0; c < rows; c++)
            {
                if (c + 1 == rows)
                {
                    Console.WriteLine(new string('*', columns));
                }
                else if (c > 0)
                {
                    Console.WriteLine(new string('*', 1) + new string(' ', columns - 2) + new string('*', 1));
                }
                else
                {
                    Console.WriteLine(new string('*', columns));
                }
            }
        }

        static void promptUser()
        {
            try
            {
                Console.WriteLine("Enter number of rows: ");
                rows = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number of columns: ");
                columns = Convert.ToInt32(Console.ReadLine());

                if (rows > 0 && columns > 0)
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
