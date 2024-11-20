using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        int number;

        public void inputData()
        {
            Console.WriteLine("Please enter the 10 different numbers to sort");
            for (i = 0; i < n; i++)
            {
                try { 
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
                
                Console.WriteLine("The numbers in ascending order are: ");
                
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine(a[i]);
                    
                }
                

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
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "BubbleSort.txt")))
                {   outputFile.WriteLine("BUBBLE SORT");
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
