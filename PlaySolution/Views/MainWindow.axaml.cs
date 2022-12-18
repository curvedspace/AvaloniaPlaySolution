using System;
using Avalonia.Controls;
using PlaySolution.Models;
using PlaySolution.ViewModels;

namespace PlaySolution.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
                        
            Console.WriteLine("MainWindow: DataContext has been set.");
            
            var myCb = this.Find<ComboBox>("MyComboBox");
            Console.WriteLine("MainWindow: MyComboBox Name = " + myCb.Name.ToString());
            
            if (myCb.SelectedItem != null)
                Console.WriteLine("MainWindow: MyComboBox SelectedItem = " + myCb.SelectedItem.ToString());
            else
            {
                Console.WriteLine("MainWindow: MyComboBox SelectedItem is NULL");
            }
        }
    }
}