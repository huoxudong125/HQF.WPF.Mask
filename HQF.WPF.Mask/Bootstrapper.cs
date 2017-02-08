using Microsoft.Practices.Unity;
using Prism.Unity;
using HQF.WPF.Mask.Views;
using System.Windows;

namespace HQF.WPF.Mask
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
