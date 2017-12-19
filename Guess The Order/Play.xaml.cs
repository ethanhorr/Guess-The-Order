using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

/*
 *  Author: Ethan Horrigan
 *  Class: Play - Loads the Current Level & Handles all events within 
*/

namespace Guess_The_Order
{
    public sealed partial class Play : Page
    {

        int guessCounter;
        int currentLevel;
        int coins;

        int[] answer = new int[] { 1, 3, 4, 2 };
        int[] guess = new int [] { 0, 0, 0, 0 };

        public Play()
        {
            this.InitializeComponent();
            RefreshCoins();
            UpdateLevel();
        }

        /* Updates Coin amount to the UI */
        private void RefreshCoins()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            Money.Text = localSettings.Values["CoinAmount"].ToString();
            coins = Convert.ToInt32(localSettings.Values["CoinAmount"]);
        }

        /* Updates current level & Loads level */
        private void UpdateLevel()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            CurrentLevel.Text = "Level: " + localSettings.Values["CurrentLevel"].ToString();
            currentLevel = Convert.ToInt32(localSettings.Values["CurrentLevel"]);
            LoadLevel();
        }
        /* Methods to Handle Image's Tapped */
        private void Image_One_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox1.Source = ImageOne.Source;
                guess[0] = 1;
               
            }
            if (guessCounter == 1)
            {
                GuessBox2.Source = ImageOne.Source;
                guess[1] = 1;
            }
            if (guessCounter == 2)
            {
                GuessBox3.Source = ImageOne.Source;
                guess[2] = 1;
            }
            if (guessCounter == 3)
            {
                GuessBox4.Source = ImageOne.Source;
                guess[3] = 1;
            }
            guessCounter++;

        }

        private void ImageTwo_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox1.Source = ImageTwo.Source;
                guess[0] = 2;
            }
            if (guessCounter == 1)
            {
                GuessBox2.Source = ImageTwo.Source;
                guess[1] = 2;
            }
            if (guessCounter == 2)
            {
                GuessBox3.Source = ImageTwo.Source;
                guess[2] = 2;
            }
            if (guessCounter == 3)
            {
                GuessBox4.Source = ImageTwo.Source;
                guess[3] = 2;
            }
            guessCounter++;
        }

        private void ImageThree_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox1.Source = ImageThree.Source;
                guess[0] = 3;
            }
            if (guessCounter == 1)
            {
                GuessBox2.Source = ImageThree.Source;
                guess[1] = 3;
            }
            if (guessCounter == 2)
            {
                GuessBox3.Source = ImageThree.Source;
                guess[2] = 3;
            }
            if (guessCounter == 3)
            {
                GuessBox4.Source = ImageThree.Source;
                guess[3] = 3;
            }
            guessCounter++;
        }

        private void ImageFour_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox1.Source = ImageFour.Source;
                guess[0] = 4;
            }
            if (guessCounter == 1)
            {
                GuessBox2.Source = ImageFour.Source;
                guess[1] = 4;
            }
            if (guessCounter == 2)
            {
                GuessBox3.Source = ImageFour.Source;
                guess[2] = 4;
            }
            if (guessCounter == 3)
            {
                GuessBox4.Source = ImageFour.Source;
                guess[3] = 4;
            }
            guessCounter++;
        }

        /* Handles the Clear Button Tapped Event */
        private void Clear_Tapped(object sender, TappedRoutedEventArgs e)
        {

            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            if (guessCounter == 0)
            {
                return;
            }
            else
            {
                clearGuessBoxes();
                guessCounter = 0;
                guess = new int[] { 0, 0, 0, 0 };
                localSettings.Values["CoinAmount"] = coins -= 10;
                RefreshCoins();
            }
        }

        /*  Clears all Guesses within the Guess Boxes (Sets Image to default) */
        private void clearGuessBoxes()
        {
            GuessBox1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/GuessBox.png"));
            GuessBox2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/GuessBox.png"));
            GuessBox3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/GuessBox.png"));
            GuessBox4.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/GuessBox.png"));
            guessCounter = 0;
            guess = new int[] { 0, 0, 0, 0 };
        }

        /* Handles Confrim Button Tapped Event */
        private void Confirm_Tapped(object sender, TappedRoutedEventArgs e)
        {
            CheckAnswer();
        }

        /* Compares Guess Array with Answer Array*/
        private void CheckAnswer()
        {
            ApplicationDataContainer localSettings = ApplicationData.Current.LocalSettings;
            if (guess[0] == answer[0] && guess[1] == answer[1] && guess[2] == answer[2] && guess[3] == answer[3])
            {
                //coins += 25;
                localSettings.Values["CoinAmount"] = coins += 25;
                clearGuessBoxes();
                RefreshCoins();
                currentLevel++;
                localSettings.Values["CurrentLevel"] = currentLevel;
                UpdateLevel();
            }
            else
            {
                clearGuessBoxes();
                RefreshCoins();
                UpdateLevel();
            }
        }

        private void LoadLevel()
        {
            switch(currentLevel)
            {
                case 1:
                    ImageOne.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/1.png"));
                    ImageTwo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/2.png"));
                    ImageThree.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/3.png"));
                    ImageFour.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_One/4.png"));
                    
                    answer = new int[] { 1, 3, 4, 2 };
                    break;
                case 2:
                    ImageOne.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Two/1.png"));
                    ImageTwo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Two/2.png"));
                    ImageThree.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Two/3.png"));
                    ImageFour.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Two/4.png"));
                    Question.Text = "Order Premier League titles from highest to lowest.";
                    answer = new int[] { 2, 1, 4, 3 };
                    break;
                case 3:
                    ImageOne.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Three/1.png"));
                    ImageTwo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Three/2.png"));
                    ImageThree.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Three/3.png"));
                    ImageFour.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Three/4.png"));
                    Question.Text = "Order these countries from highest population to lowest.";
                    answer = new int[] { 3, 1, 4, 2 };
                    break;
                case 4:
                    ImageOne.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Four/1.png"));
                    ImageTwo.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Four/2.png"));
                    ImageThree.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Four/3.png"));
                    ImageFour.Source = new BitmapImage(new Uri("ms-appx:///Assets/Level_Four/4.png"));
                    Question.Text = "Order US presidents in ascending order.";
                    answer = new int[] { 4, 1, 2, 3 };
                    break;
            }
            guessCounter = 0;
            guess = new int[] { 0, 0, 0, 0 };
        }

    }
}
