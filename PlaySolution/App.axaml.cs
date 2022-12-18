using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using PlaySolution.ViewModels;
using PlaySolution.Views;

namespace PlaySolution
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
                
                Console.WriteLine("App: DataContext has been set.");
            
                var myCb = desktop.MainWindow.Find<ComboBox>("MyComboBox");
                Console.WriteLine("App: MyComboBox Name = " + myCb.Name.ToString());
            
                if (myCb.SelectedItem != null)
                    Console.WriteLine("MainWindow: MyComboBox SelectedItem = " + myCb.SelectedItem.ToString());
                else
                {
                    Console.WriteLine("MainWindow: MyComboBox SelectedItem is NULL");
                }
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}