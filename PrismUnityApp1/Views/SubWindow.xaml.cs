using Prism.Regions;
using System;
using System.Windows;

namespace PrismUnityApp1.Views
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        public IRegionManager RegionManager { get; }

        public SubWindow(IRegionManager regionManager)
        {
            RegionManager = regionManager;

            InitializeComponent();
        }

        protected override void OnContentRendered(EventArgs e)
        {
            base.OnContentRendered(e);

            RegionManager.RequestNavigate("ContentRegion", nameof(SubControl1));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate("ContentRegion", nameof(SubControl1));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            RegionManager.RequestNavigate("ContentRegion", nameof(SubControl2));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
