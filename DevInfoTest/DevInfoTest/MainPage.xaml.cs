using Xamarin.Essentials;
using Xamarin.Forms;

namespace DevInfoTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            DeviceNameLabel.Text = DeviceInfo.Name;
            DeviceTypeLabel.Text = DeviceInfo.DeviceType.ToString();
        }
    }
}
