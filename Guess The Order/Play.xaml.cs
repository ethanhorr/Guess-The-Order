﻿using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Guess_The_Order
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Play : Page
    {

        int guessCounter;
        public Play()
        {
            this.InitializeComponent();
        }

        private void Image_One_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (guessCounter == 0)
            {
                GuessBox1.Source = ImageOne.Source;
            }
            if (guessCounter == 1)
            {
                GuessBox1.Source = ImageTwo.Source;
            }
            if (guessCounter == 2)
            {
                GuessBox1.Source = ImageThree.Source;
   
            }
            if (guessCounter == 3)
            {
                GuessBox1.Source = ImageFour.Source;
            }
            guessCounter++;

        }
        private void ImageOne_DragLeave(object sender, DragEventArgs e)
        {

            GuessBox1.Source = ImageOne.Source;
        }
    }
}
