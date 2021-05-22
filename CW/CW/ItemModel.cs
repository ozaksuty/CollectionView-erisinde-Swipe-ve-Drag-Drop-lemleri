using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;

namespace CW
{
    public class ItemModel : INotifyPropertyChanged
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        private bool _fav;
        public bool Fav
        {
            get
            {
                return _fav;
            }
            set
            {
                _fav = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        void RaisePropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}