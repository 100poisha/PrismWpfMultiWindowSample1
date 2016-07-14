﻿using Prism.Mvvm;

namespace PrismUnityApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "MainWindow";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel()
        {

        }
    }
}
