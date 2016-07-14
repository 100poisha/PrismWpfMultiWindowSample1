using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PrismUnityApp1.ViewModels
{
    public class SubWindowViewModel : BindableBase
    {
        private string _title = "SubWindow";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public SubWindowViewModel()
        {

        }
    }
}
