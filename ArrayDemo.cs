using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] scores = { 45, 19, 2, 16, 8, 190, .8, 510, 6, 18 };

            ClassArray();
        }

        private static void Display (double [] array)
        {
            string str = string.Empty;
            foreach(double score in array)
                str += (score + "\n");
            MessageBox.Show(str, "Scores");
        }
        
        private static void DisplayFor(double [] array)
        {
            string str = string.Empty;
            for (int i = 0; i < array.Length; i++)
                str += (array[i] + "\n");
            MessageBox.Show(str, "Scores");
        }
        
        private static void GetIndex(double [] array)
        {
            double x = 510;
            double myIndex = Array.BinarySearch(array, x);

            MessageBox.Show("Index is " + myIndex);
        }
        
        private static void GetScoresGreaterThan(double [] array)
        {
            double find = 0;
            int counter = 0;

            Console.Write("Enter score to find: ");
            find = double.Parse(Console.ReadLine());

            foreach (double index in array)
            {
                if (find > index)
                    counter++;
            }
            if (counter >= array.Length)
                MessageBox.Show(find + " is greater than all the indexes in this list.");
            else
                MessageBox.Show(find + " is greater than " + counter + " of the indexes in this list.");
        }
        
        private static void Average (double [] array)
        {
            double average;
            double totalScores = 0;
            int counter = 0;
            
            foreach(double index in array)
            {
                totalScores += index;
                counter++;
            }
            average = totalScores / counter;
            MessageBox.Show("The average is: " + average);
        }
        
        private static void UnknownAmount()
        {
            string[] numbers = new string[50];
            string inValue;
            int i = 0;
            string stringMessage = string.Empty;

            Console.Write("Enter number: ");
            inValue = Console.ReadLine();

            while (!inValue.Equals("Q")|| !inValue.Equals("q"))
            {
                numbers[i] = inValue;
                i++;

                Console.Write("Enter number: ");
                inValue = Console.ReadLine();
            }

            for (int n = 0; n <= i; n++)
                stringMessage += numbers[n] + "\n";
            MessageBox.Show(stringMessage);
        }
        private static void ClassArray()
        {
            Scores aScore = new Scores();
            for (int i = 0; i < 3; i++)
            { 
                Console.Write("Enter score: ");
                aScore.Score = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(aScore.ToString());
            Console.Read();              
        }
    }
}
