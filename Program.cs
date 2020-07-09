using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double x_sum = 0;
            double y_sum = 0;
            double xy_sum = 0;
            double xx_sum = 0;
            Console.Write("Введите X: ");
            string[] in_data_x = Console.ReadLine().Split(' ');
            Console.Write("Введите Y: ");
            string[] in_data_y = Console.ReadLine().Split(' ');
            int n = in_data_x.Length;

            for (int i = 0; i < n; i++)
            {
                x_sum = x_sum + Convert.ToDouble(in_data_x[i]);
                y_sum = y_sum + Convert.ToDouble(in_data_y[i]);
                xy_sum = xy_sum + Convert.ToDouble(in_data_x[i]) * Convert.ToDouble(in_data_y[i]);
                xx_sum = xx_sum + Convert.ToDouble(in_data_x[i]) * Convert.ToDouble(in_data_x[i]);
            }

            a = (n * xy_sum - x_sum * y_sum) / (n * xx_sum - x_sum * x_sum);
            b = (y_sum - a * x_sum) / n;

            if (b > 0)
            {
                Console.WriteLine("y = " + a + "x + " + b);
            }
            else
            {
                Console.WriteLine("y = " + a + "x " + b);
            }
            Console.ReadLine();
        }
    }
}
