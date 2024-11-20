namespace Entrega4Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DisplayMenu();

        }
        
        static void DisplayMenu()
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n ****** SORTING METHODS MENU ******");
                Console.WriteLine("1. Bubble Sort");
                Console.WriteLine("2. Shell Sort");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Insertion Sort");
                Console.WriteLine("5. Exit");
                Console.Write("Enter the number of the sorting method you want to use: ");
                try
                {
                    string? inputOption = Console.ReadLine();
                    if (string.IsNullOrEmpty(inputOption))
                    {
                        Console.WriteLine("Please enter a number");
                        continue;
                    }
                    int option = int.Parse(inputOption);
                    

                    switch (option)
                    {
                        case 1:
                            BubbleSort bubble = new BubbleSort();
                            bubble.inputData();
                            bubble.sortData();
                            bubble.displayData();
                            break;
                        case 2:
                            ShellSort shell = new ShellSort();
                            shell.inputData();
                            shell.sortData();
                            shell.displayData();
                            break;
                        case 3:
                            SelectionSort selection = new SelectionSort();
                            selection.inputData();
                            selection.sortData();
                            selection.displayData();
                            break;
                        case 4:
                            InsertionSort insertion = new InsertionSort();
                            insertion.inputData();
                            insertion.sortData();
                            insertion.displayData();
                            break;
                        case 5:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid option");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a number");
                }

            }
        }
       

    }
}

