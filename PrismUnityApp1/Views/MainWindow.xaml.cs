using Prism.Regions;
using System.Windows;
using System;

namespace PrismUnityApp1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public IRegionManager RegionManager { get; }

        public MainWindow(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            InitializeComponent();
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            RegionManager.RequestNavigate("ContentRegion", nameof(MainControl1));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate("ContentRegion", nameof(MainControl1));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate("ContentRegion", nameof(MainControl2));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var regionManager = RegionManager.CreateRegionManager();
            var subWindow = new SubWindow(regionManager);
            subWindow.ShowDialog();
        }
    }
}
