using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Guess_The_Order
{
    public sealed partial class Play : Page
    {

        int guessCounter;
        int[] answer = new int[] { 1, 4, 3, 2 };
        int[] guess = new int [4];

        public Play()
        {
            this.InitializeComponent();
        }

        private void Image_One_Tapped(object sender, TappedRoutedEventArgs e)
        {
            int j = 0;
            if (guessCounter == 0)
            {
                GuessBox1.Source = ImageOne.Source;
                j = 1;
            }
            if (guessCounter == 1)
            {
                GuessBox1.Source = ImageTwo.Source;
                j = 2;
            }
            if (guessCounter == 2)
            {
                GuessBox1.Source = ImageThree.Source;
                j = 3;
            }
            if (guessCounter == 3)
            {
                GuessBox1.Source = ImageFour.Source;
                j = 4;
            }
            guessCounter++;
          guess[1] = j;

        }

        private void ImageTwo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox2.Source = ImageOne.Source;
            }
            if (guessCounter == 1)
            {
                GuessBox2.Source = ImageTwo.Source;
            }
            if (guessCounter == 2)
            {
                GuessBox2.Source = ImageThree.Source;

            }
            if (guessCounter == 3)
            {
                GuessBox2.Source = ImageFour.Source;
            }
            guessCounter++;
        }

        private void ImageThree_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox3.Source = ImageOne.Source;
            }
            if (guessCounter == 1)
            {
                GuessBox3.Source = ImageTwo.Source;
            }
            if (guessCounter == 2)
            {
                GuessBox3.Source = ImageThree.Source;

            }
            if (guessCounter == 3)
            {
                GuessBox3.Source = ImageFour.Source;
            }
            guessCounter++;
        }

        private void ImageFour_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox4.Source = ImageOne.Source;
            }
            if (guessCounter == 1)
            {
                GuessBox4.Source = ImageTwo.Source;
            }
            if (guessCounter == 2)
            {
                GuessBox4.Source = ImageThree.Source;

            }
            if (guessCounter == 3)
            {
                GuessBox4.Source = ImageFour.Source;
            }
            guessCounter++;
        }


        private void clearGuessBox()
        {

        }
    }
}
