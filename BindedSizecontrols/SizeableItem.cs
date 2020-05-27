using GalaSoft.MvvmLight;

namespace BindedSizeControls
{
    public class SizeableItem : ViewModelBase
    {
        private string _name; public string Name { get => $"{Column}-{Size}"; set { Set(() => Name, ref _name, value); }}

        
        private int _column; 
        public int Column { get => _column; set { Set(() => Column, ref _column, value); RaisePropertyChanged(nameof(Name)); } }

        private int _size;
        public int Size { get => _size; set { Set(() => Size, ref _size, value) ; RaisePropertyChanged(nameof(Name)); } }


        public SizeableItem() : this(1,1)
        {
            
        }

        public SizeableItem(int column=1, int size=1)
        {

            Column = column;
            Size = size;
        }
    }
}
