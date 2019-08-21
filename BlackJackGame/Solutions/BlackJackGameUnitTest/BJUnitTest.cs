using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJack;
using System.Collections.Generic;

namespace BlackJackUnitTest
{
    [TestClass]
    public class BJUnitTest
    {
        [TestMethod]
        public void CheckDraw()     // Test case if both players score is same
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(20, 20);
            Assert.AreEqual(result, "Game draw");
        }
        [TestMethod]
        public void CheckIfUserWins1()     // Test case If the score of both players is less than 21, where User's score is close to 21
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(20, 18);
            Assert.AreEqual(result, "You won !!");
        }
        [TestMethod]
        public void CheckIfUserWins2()     // Test case If the score of both players is less than 21, where Computer's score is close to 21
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(17, 19);
            Assert.AreEqual(result, "Computer has won !!");
        }
        [TestMethod]
        public void CheckIfUserWins3()     // Test case If the score of both players is greater than 21, where User's score is close to 21
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(23, 27);
            Assert.AreEqual(result, "You won !!");
        }
        [TestMethod]
        public void CheckIfUserWins4()     // Test case If the score of both players is greater than 21, where Computer's score is close to 21
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(26, 22);
            Assert.AreEqual(result, "Computer has won !!");
        }

        [TestMethod]
        public void CheckIfUserWins5()     // Test case If the score of User1  player is less than 21 and User2 player is greater than 21, then User1 has won the game where it closer to 21
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(19, 23);
            Assert.AreEqual(result, "You won !!");
        }
        [TestMethod]
        public void CheckIfUserWins6()     // Test case If the score of User1  player is greater than 21 and User2 player is less than 21, then User1 has won the game where it closer to 21
        {
            BlackJackMain obj = new BlackJackMain();
            string result = obj.winner(23, 19);
            Assert.AreEqual(result, "Computer has won !!");
        }
       
        [TestMethod]
        public void ChecktheRandomnumber() // check the random number is in the range bteween 1 and 10 
        {
            BlackJackMain obj = new BlackJackMain();
            int randomNumb = obj.Rand();
            bool isContains = true;
            if (randomNumb <= 10)
            {
                isContains = true;
            }
            else
            {
                isContains = false;
            }          
            Assert.AreEqual(isContains,true);
        }
    }
}
