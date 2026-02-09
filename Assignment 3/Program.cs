namespace Assignment_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] seats = { { 1, 1, 1, 1 },{ 1, 1, 1, 1 } ,{ 1, 1, 1, 1 } ,{ 1, 1, 1, 1 } } ;
            int row, column;
            Console.WriteLine("Welcome to the seat reservation system!");
 


          do
             {
                 Console.Write("Please enter the row number (0-3): ");
                 if(!int.TryParse(Console.ReadLine(), out row))
                 {
                     Console.WriteLine("Invalid input!");
                     continue;
                 }
                 Console.Write("Please enter the column number (0-3): ");
                 if (!int.TryParse(Console.ReadLine(), out column))
                 {
                     Console.WriteLine("Invalid input!");
                     continue;
                 }
                if (row < 0 || row > 3 || column < 0 || column > 3)
                {
                    Console.WriteLine("Index is Out of bounds!");
                    continue;
                }
                if (seats[row, column] == 1)
                {
                    seats[row, column] = 0;
                    Console.WriteLine("Seat reserved successfully!");
                }
                else
                {
                    Console.WriteLine("Sorry, that seat is already reserved. Choose another seat");
                }
            } while (true);

        }
    }
}
