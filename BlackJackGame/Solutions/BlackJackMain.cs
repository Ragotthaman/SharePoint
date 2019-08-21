using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class BlackJackMain : BJAbstractVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********* WELCOME TO BLACK JACK GAME*************");
            Console.WriteLine("---------------------------------------\n");
            try
            {
                int[] Comp = new int[50];
                int[] User = new int[50];
                int i; char flag;
                int Totcomp = 0; int Totme = 0;

                BlackJackMain objBlackJack = new BlackJackMain();               //Creating an object for calling abstract class members

                #region Assigning the first 2 cards
                User[0] = objBlackJack.Rand();                  //Assigning the first 2 cards for User
                User[1] = objBlackJack.Rand();

                Comp[0] = objBlackJack.Rand();            //Assigning the first 2 cards for Computer
                Comp[1] = objBlackJack.Rand();
                #endregion

                Totcomp = Comp[0] + Comp[1];
                Totme = User[0] + User[1];
                Console.WriteLine("Your Cards: " + User[0] + " " + User[1] + " = " + Totme);                                                //Displaying the first 2 card values of both User and Computer
                Console.WriteLine("Computer Cards: " + Comp[0] + " " + Comp[1] + " = " + Totcomp + "\n");

                #region User's Turn
                for (i = 2; Totme <17; i++)                           //User's Turn. The loop will run till the total of its card values doesnot reach 17                   
                {
                    Console.WriteLine("\nDo you want another Card (y/n)? ");
                    flag = Console.ReadKey().KeyChar;
                    if (flag == 'y')
                    {
                        User[i] = objBlackJack.Rand();
                        Totme = Totme + User[i];
                        Console.WriteLine("\n\nHit: " + User[i] + " ,Your total is " + Totme);
                    }
                    else
                    {
                        break;
                    }
                        
                }
                #endregion

                Console.WriteLine("\n");

                #region Computer's Turn
                for (i = 2; Totcomp < 17; i++)      //Computer's Turn. The loop will run till the total of its card values doesnot reach 17
                {
                    Comp[i] = objBlackJack.Rand();
                    Console.WriteLine("\nThe Computer takes a card: " + Comp[i]); 
                    Totcomp = Totcomp + Comp[i];
                }
                #endregion

                Console.WriteLine("\n\nYour Score: " + Totme);     //Displaying the score of both user and Computer
                Console.WriteLine("\nComputer Score: " + Totcomp+"\n");

                #region Announcing the Winner
                Console.WriteLine(objBlackJack.winner(Totme, Totcomp));
                #endregion
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception is: " + e.Message);
            }

        }
        public override int Rand()
        {
            System.Threading.Thread.Sleep(50);
            Random random = new Random();
            return random.Next(1, 10);              //Assigning the first 2 cards for User
        }
        public override string winner(int me, int comp)
        {
            string Userwin = "You won !!";
            string Computerwin  = "Computer has won !!";
            string draw = "Game draw";

            if (me < 21 && comp < 21)                     //If the score of both players is less than 21, the winner is annouced whose score is close to 21, but not exceeding 21
            {
                if (me > comp)
                    return Userwin;
                else if (me == comp)                      //If the score of both players is equal, then Game is Drawn
                    return draw;
                else
                    return Computerwin;
            }
            else if (me == comp)                      //If the score of both players is equal, then Game is Drawn
                return draw;
            else if (me < comp)                       //If the score of both players is greater than 21, the winner is annouced whose score is lesser than the other, as the player tried his/her/its best to make it less than 21
                return Userwin;
            else
                return Computerwin;
        }
    }
}
