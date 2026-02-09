namespace Assignment_3
{
    internal class Program
    {
        static bool isFull(char[,] board)
        {
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }
        static void PrintBoard(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " | ");
                }
                Console.WriteLine("\n-------------");
            }
        }
        static char CheckWin(char[,] board)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((board[i, 0] == board[i, 1]) && (board[i, 1] == board[i, 2]))
                { if(board[i, 0] == 'X')
                        return 'X';
                    else if(board[i, 0] == 'O')
                        return 'O';
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if ((board[0, i] == board[1, i]) && (board[1, i] == board[2, i]))
                {
                    if (board[0, i] == 'X')
                        return 'X';
                    else if (board[0, i] == 'O')
                        return 'O';
                }
            }
                if (board[0,0] == board[1,1] && board[1,1] == board[2,2])
                {
                    if (board[0, 0] == 'X')
                        return 'X';
                    else if (board[0, 0] == 'O')
                        return 'O';
                }
            else if (board[0,2] == board[1,1] && board[1,1] == board[2,0])
                {
                if (board[0, 2] == 'X')
                    return 'X';
                else if (board[0, 2] == 'O')
                    return 'O';
                }
                if(isFull(board))
                {
                    return 'D';
                }
            return 'N';
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!\n");
            char[,] board = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
            int turn = 0 , row , column;
            while (true)
            {
                if(turn % 2 == 0)
                {
                    Console.Write("Player X's turn. ");
                }
                else
                {
                    Console.Write("Player O's turn. ");
                }
                Console.Write("Enter row (0-2): ");
                while(!int.TryParse(Console.ReadLine(), out row) || row < 0 || row > 2)
                {
                    Console.Write("Invalid input. Please enter a number between 0 and 2: ");
                }
                Console.Write("Enter column (0-2): ");
                while (!int.TryParse(Console.ReadLine(), out column) || column < 0 || column > 2)
                {
                    Console.Write("Invalid input. Please enter a number between 0 and 2: ");
                }
                if (board[row,column] != ' ') { 
                Console.WriteLine("Cell already occupied. Please choose another cell.");
                    continue;
                }
                if (turn % 2 == 0)
                {
                    board[row, column] = 'X';
                }
                else
                {
                    board[row, column] = 'O';
                }
                PrintBoard(board);
                if(CheckWin(board) == 'X')
                    {
                    Console.WriteLine("Player X wins!");
                    break;
                }
                else if(CheckWin(board) == 'O')
                {
                    Console.WriteLine("Player O wins!");
                    break;
                }
                else if(CheckWin(board) == 'D')
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }
                turn++;

            }
        }
    }
}
