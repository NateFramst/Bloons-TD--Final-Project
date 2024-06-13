using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bloons_TD__Final_Project
{
    public partial class HighscoreScreen : UserControl
    {
        Highscore first;

        Highscore second;

        Highscore third;
        public HighscoreScreen()
        {
            InitializeComponent();

            //Highscore balls = new Highscore("jimmybob", "jimmybob", 1000);
            //Highscore balls1 = new Highscore("jimmyRob", "jimmyRob", 2000);
            //Highscore balls2 = new Highscore("jimmyJob", "jimmyJob", 3000);

            //Form1.highscores.Add(balls);
            //Form1.highscores.Add(balls1);
            //Form1.highscores.Add(balls2);

           

            List<int> scores = new List<int>();
            foreach(Highscore h in Form1.highscores)
            {
                scores.Add(h.highscore);
            }

            int[] highScoreArray = scores.ToArray();

            quickSort(highScoreArray, 0 , highScoreArray.Length - 1);

            Form1.highscores.Reverse();


            firstUsernameLabel.Text = Form1.highscores[0].userName;
            firstHighscoreLabel.Text = Form1.highscores[0].highscore.ToString();

            if (Form1.highscores.Count > 1)
            {
                secondUsernameLabel.Text = Form1.highscores[1].userName;
                secondHighscoreLabel.Text = Form1.highscores[1].highscore.ToString();
            }

            if (Form1.highscores.Count > 2)
            {
                thirdUsernameLabel.Text = Form1.highscores[2].userName;
                thirdHighscoreLabel.Text = Form1.highscores[2].highscore.ToString();
            }
           



        }
        static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
        static int partition(int[] arr, int low, int high)
        {
            // Choosing the pivot
            int pivot = arr[high];

            // Index of smaller element and indicates
            // the right position of pivot found so far
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {

                // If current element is smaller than the pivot
                if (arr[j] < pivot)
                {

                    // Increment index of smaller element
                    i++;
                    swap(arr, i, j);
                }
            }
            swap(arr, i + 1, high);
            return (i + 1);
        }

        // The main function that implements QuickSort
        // arr[] --> Array to be sorted,
        // low --> Starting index,
        // high --> Ending index
        public void quickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {

                // pi is partitioning index, arr[p]
                // is now at right place
                int pi = partition(arr, low, high);

                // Separately sort elements before
                // and after partition index
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }



    }
}
