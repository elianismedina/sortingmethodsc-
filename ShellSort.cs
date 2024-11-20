using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Entrega4Programacion
{
    class ShellSort
    {

        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int i, j, temp, n = 10;
        int number;

        public void inputData()
        {
            Console.WriteLine("Please enter the 10 different numbers to sort");
            for (i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Enter number {0}", i + 1);
                    string? input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Please enter a number");
                        i--;
                        continue;
                    }
                    number = int.Parse(input);

                    if (a.Contains(number))
                    {
                        Console.WriteLine("Please enter a different number");
                        i--;
                    }
                    else
                    {
                        a[i] = int.Parse(input);

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number");
                    i--;
                }
            }
        }
        public void sortData()
        {
            Console.WriteLine("sorting data through Shell sort....");
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = n / 2;
            while (salto > 0)
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (n - salto))
                    {
                        if (a[e - 1] > a[(e - 1) + salto])
                        {
                            auxi = a[(e - 1) + salto];
                            a[(e - 1) + salto] = a[e - 1];
                            a[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;
            }

        }
        public void displayData()
        {
            try
            {
                string filename = "ShellSort.txt";
                StreamWriter sw = File.AppendText(filename);
                Console.WriteLine("The numbers in ascending order are: ");
                sw.WriteLine("The numbers in ascending order are: ");
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                    sw.WriteLine(a[i]);
                }
                sw.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving and displaying the Data");
            }

        }
        public void saveData()
        {
            try
            {
                string docPath = @"C:\Users\elianismedina\C#-projects\Entrega4Programacion";
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "ShellSort.txt")))
                {
                    outputFile.WriteLine("SHELL SORT");
                    outputFile.WriteLine("The numbers in ascending order are: ");
                    foreach (int number in a)
                        outputFile.WriteLine(number);
                }
                Console.WriteLine("document saved");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error saving and displaying the Data");
            }
        }
    }
}
