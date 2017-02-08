using HQF.WPF.Mask.Views;
using Prism.Mvvm;
using Prism.Regions;

namespace HQF.WPF.Mask.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Prism Unity Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IRegionManager regionManager)
        {
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(OpacityMaskView));
        }
    }
}
