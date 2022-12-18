using System;
using System.Collections.Generic;
using Avalonia.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using PlaySolution.Models;

namespace PlaySolution.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        [ObservableProperty]
        private DataRecord? _myRecord;

        [ObservableProperty] 
        private List<CodeTable> _myList;

        [ObservableProperty]
        private DateTimeOffset _currentDate = DateTime.Today;

        public MainWindowViewModel()
        {
            _myList = new List<CodeTable>()
            {
                new CodeTable() { Id = 1, Code = "TEST", Description = "Item 1" },
                new CodeTable() { Id = 2, Code = "HI", Description = "Item 2" }
            };

            _myRecord = new DataRecord()
                { Id = 1, Name = "Data Record A", StartDate = new DateTimeOffset(new DateTime(2000, 02, 04)) };

            _myRecord.MyCodeTable.Id = 2;
            _myRecord.MyCodeTable.Code = "HI";
            _myRecord.MyCodeTable.Description = "Item 2";
            
            Console.WriteLine("MainWindowViewModel: MyRecord.MyCodeTable = " + _myRecord.MyCodeTable.ToString());
        }
    }
}