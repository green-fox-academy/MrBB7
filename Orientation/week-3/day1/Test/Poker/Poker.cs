using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerHandsApp
{
     public class Poker
    {
        public string GetValue(string input)
        {
            return input.ToString();
        }

        public bool CheckInputLength12(string input)
        {
            string[] temp = input.Split();
            return temp.Length == 12;
        }

        public string GetHands(string input)
        {
            string[] raw = input.Split(' ');
            string[] black = new string[5];
            string[] white = new string[5];

            for (int i = 0; i < 5; i++)
            {
                black[i] = raw[i + 1];
                white[i] = raw[i + 7];
            }

            return "White wins";
        }

        public enum CardValue
        {
            T = 10,
            J = 11,
            Q = 12,
            K = 13,
            A = 14
        };
    }
}
