using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Scores
    {
        int[] scoresArray = new int[3];
        int i;

        public Scores(){}
        
        public int Score { set { scoresArray[i] = value; i++; } }

        public override string ToString()
        {
            string str = string.Empty;

            foreach (int score in scoresArray)
                str += score + "\n";

            return str;
        }
    }
}
