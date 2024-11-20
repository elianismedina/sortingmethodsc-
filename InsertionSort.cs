using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega4Programacion
{
    class InsertionSort
    {

        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        int i, j, temp, n = 10;
        public void inputData()
        {
            Console.WriteLine("Please enter the 10 different numbers to sort");
            for (i = 0; i < n; i++)
            {
                try
                {
                    Console.WriteLine("Please enter number {0}", i + 1);
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
            Console.WriteLine("sorting data through Insertion sort....");
            for (int i = 1; i < n; i++)
            {
                int key = a[i];
                int j = i - 1;
                while (j >= 0 && a[j] > key)
                {
                    a[j + 1] = a[j];
                    j--;
                }
                a[j + 1] = key;
            }
        }
        public void displayData()
        {
            try
            {
                String filename = "InsertionSort.txt";
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
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "InsertionSort.txt")))
                {
                    outputFile.WriteLine("INSERTION SORT");
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

