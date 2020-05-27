using BindedSizecControls;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace BindedSizeControls
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<SizeableItem> _items= new ObservableCollection<SizeableItem>();
        public ObservableCollection<SizeableItem> Items { get => _items; set { Set(() => Items, ref _items, value); }}

        private bool _isTwoFields;
        public bool IsTwoFields { get => _isTwoFields; set { Set(() => IsTwoFields, ref _isTwoFields, value); }}

        public MainWindowViewModel()
        {
            loadSampleData();
        }

        private void loadSampleData()
        {
            Items.Add(new SizeableItem(1, 1));
            Items.Add(new SizeableItem(3 , 2));

        }
    }
}
