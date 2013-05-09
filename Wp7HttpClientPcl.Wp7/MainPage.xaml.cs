using System.Windows;
using Microsoft.Phone.Controls;
using Wp7HttpClientPcl.Core;

namespace Wp7HttpClientPcl.Wp7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var s = await DataGetter.GetSomeEarthquakeData();
            MessageBox.Show("Data: " + s);
        }
    }
}