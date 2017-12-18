using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Guess_The_Order
{

    public sealed partial class MainPage : Page
    {
        public MainPage()

        {
            ApplicationView view = ApplicationView.GetForCurrentView();
            /* Sets app to fullscreen */
            view.TryEnterFullScreenMode();
            this.InitializeComponent();
        }

        private void Play_Button(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Play));
        }
    }
}
