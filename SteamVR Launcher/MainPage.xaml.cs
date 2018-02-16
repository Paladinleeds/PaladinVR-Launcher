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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SteamVR_Launcher
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private async void LaunchURI_Click(object sender, RoutedEventArgs e)
        {
            // The URI to launch
            var uriSteamVR = new Uri(@"steam://run/250820");

            // Launch the URI
            var success = await Windows.System.Launcher.LaunchUriAsync(uriSteamVR);

            if (success)
            {
                // URI launched
            }
            else
            {
                // URI launch failed
                ContentDialog launchFailed = new ContentDialog
                {
                    Title = "Failed",
                    Content = "I'm sorry, but SteamVR failed to load. Please try again.",
                    CloseButtonText = "Understood!"
                };

                ContentDialogResult result = await launchFailed.ShowAsync();
            }
        }

        public MainPage()
        {
            this.InitializeComponent();
        }

        
    }
}
