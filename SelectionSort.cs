using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega4Programacion
{
    class SelectionSort
    {

        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int i, j, temp, n = 10;
        public void inputData()
        {
            Console.WriteLine("Please enter the 10 numbers to sort");
            for (i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Enter number {0}", i + 1);
                    a[i] = Convert.ToInt32(Console.ReadLine());
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
            Console.WriteLine("sorting data through Selection sort....");
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }
        }
        public void displayData()
        {
            try
            {
                String filename = "SelectionSort.txt";
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
    }
}
