using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega4Programacion
{
    class BubbleSort
    {
        int[] a = { 0, 0, 0 ,0, 0, 0, 0, 0, 0, 0 };
        int i, j, temp, n = 10;
        bool swapped;
        public void inputData()
        {
            Console.WriteLine("Please enter the 10 numbers to sort");
            for (i = 0; i < n; i++)
            {
                try { 
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
            Console.WriteLine("sorting data through Bubble sort....");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        public void displayData()
        {
            try
            {
                String filename = "BubbleSort.txt";
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
