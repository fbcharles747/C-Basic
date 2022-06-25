using System;

namespace TicTacToe
{
    internal class Program
    {
        static char[,] playerField =
        {
            {'1','2','3'},
            {'4','5','6' },
            {'7','8','9' }
        };
        static char[,] playerFieldInit =
        {
            {'1','2','3'},
            {'4','5','6' },
            {'7','8','9' }
        };
        static int input = 0;
        static int turns;

        static void Main(string[] args)
        {

            SetField();
            int player = 2;
            
            bool inputCorrect=true;
            do
            {
                if(player == 2)
                {
                    player = 1;
                }
                else
                {
                    player = 2;
                }

                do
                {
                    Console.WriteLine($"Player{player}: Please choose your field! ");
                    inputCorrect = ValidateInput();
                    inputCorrect = FieldNotUsed(inputCorrect);

                } while (!inputCorrect);
                EnterOorXBasedOnPlayer(player, input);
                SetField();
                checkWinner();
                if (turns.Equals(10))
                {
                    Console.WriteLine("draw");
                    ResetField();
                }

            } while(true);
        }

        private static void checkWinner()
        {
            char[] playerSymbol = { 'X', 'O' };
            foreach(char c in playerSymbol)
            {
                if (playerField[0,0].Equals(c)&& playerField[0, 1].Equals(c) && playerField[0, 2].Equals(c)
                    || playerField[0, 0].Equals(c) && playerField[1, 1].Equals(c) && playerField[2, 2].Equals(c)
                    || playerField[0, 0].Equals(c) && playerField[1, 0].Equals(c) && playerField[2, 0].Equals(c)
                    || playerField[0, 1].Equals(c) && playerField[1, 1].Equals(c) && playerField[2, 1].Equals(c)
                    || playerField[0, 2].Equals(c) && playerField[1, 1].Equals(c) && playerField[2, 0].Equals(c)
                    || playerField[0, 2].Equals(c) && playerField[1, 2].Equals(c) && playerField[2, 2].Equals(c)
                    || playerField[1, 0].Equals(c) && playerField[1, 1].Equals(c) && playerField[1, 2].Equals(c)
                    || playerField[2, 0].Equals(c) && playerField[2, 1].Equals(c) && playerField[2, 2].Equals(c))
                {
                    if (c == 'X')
                    {
                        Console.WriteLine("player 2 has won!");
                    }
                    else
                    {
                        Console.WriteLine("player 1 has won!");
                    }
                    
                    ResetField();
                    
                }
            }
        }

        private static void ResetField()
        {

            Console.WriteLine("press any key to reset the field");
            Console.Read();
            turns = 0;
            playerField = playerFieldInit;
            SetField();
        }

        private static bool FieldNotUsed(bool inputCorrect)
        {
            switch (input)
            {
                case 1:
                    inputCorrect = playerField[0, 0].Equals('1');
                    break;
                case 2:
                    inputCorrect = playerField[0, 1].Equals('2');
                    break;
                case 3:
                    inputCorrect = playerField[0, 2].Equals('3');
                    break;
                case 4:
                    inputCorrect = playerField[1, 0].Equals('4');
                    break;
                case 5:
                    inputCorrect = playerField[1, 1].Equals('5');
                    break;
                case 6:
                    inputCorrect = playerField[1, 2].Equals('6');
                    break;
                case 7:
                    inputCorrect = playerField[2, 0].Equals('7');
                    break;
                case 8:
                    inputCorrect = playerField[2, 1].Equals('8');
                    break;
                case 9:
                    inputCorrect = playerField[2, 2].Equals('9');
                    break;
            }
            if (!inputCorrect)
            {
                Console.WriteLine("The entered field is used.");
            }

            return inputCorrect;
        }

        static bool ValidateInput()
        {
            bool isParsible=int.TryParse( Console.ReadLine(), out input);
            if (input > 9 || input < 1)
            {
                Console.WriteLine("input must be between 1 to 9");
                return false;
            }
            if (!isParsible)
            {
                Console.WriteLine("input is not an integer. ");
                return false;
            }
            return true;

        }
        

        

        static void EnterOorXBasedOnPlayer(int player,int input)
        {
            char playerSign=' ';
            if (player == 1)
            {
                playerSign = 'O';
            }
            else if(player == 2)
            {
                playerSign = 'X';
            }
            switch (input)
            {
                case 1:
                    playerField[0,0] = playerSign;
                    break;
                case 2:
                    playerField[0, 1] = playerSign;
                    break;
                case 3:
                    playerField[0, 2] = playerSign;
                    break;
                case 4:
                    playerField[1, 0] = playerSign;
                    break;
                case 5:
                    playerField[1, 1] = playerSign;
                    break;
                case 6:
                    playerField[1, 2] = playerSign;
                    break;
                case 7:
                    playerField[2, 0] = playerSign;
                    break;
                case 8:
                    playerField[2, 1] = playerSign;
                    break;
                case 9:
                    playerField[2, 2] = playerSign;
                    break;
            }
            


        }
        static void SetField()
        {
            Console.Clear();
            
            Console.WriteLine("     |       |       ");
            Console.WriteLine("   {0} |   {1}   |  {2} ", playerField[0, 0], playerField[0, 1], playerField[0,2]);
            Console.WriteLine("_____|_______|_______");
            Console.WriteLine("     |       |       ");
            Console.WriteLine("   {0} |   {1}   |  {2} ", playerField[1, 0], playerField[1, 1], playerField[1, 2]);
            Console.WriteLine("_____|_______|_______");
            Console.WriteLine("     |       |       ");
            Console.WriteLine("   {0} |   {1}   |  {2} ", playerField[2, 0], playerField[2, 1], playerField[2, 2]);
            turns++;

            
            
        }
    }
        
}
