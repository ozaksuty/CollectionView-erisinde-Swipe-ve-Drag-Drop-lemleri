using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace CW
{
    public class MainPageViewModel
    {
        private IList<ItemModel> _list;
        public IList<ItemModel> List
        {
            get
            {
                if (_list == null)
                    _list = new ObservableCollection<ItemModel>();
                return _list;
            }
            set
            {
                _list = value;
            }
        }

        void Bind()
        {
            List.Clear();
            for (int i = 1; i <= 10; i++)
            {
                List.Add(new ItemModel
                {
                    Id = i,
                    Name = Guid.NewGuid().ToString(),
                    Image = $"https://picsum.photos/id/{i}/200/300?grayscale&blur=2"
                });
            }
        }

        public ICommand FavoriteCommand => new Command((o) =>
        {
            if (o != null && o is ItemModel item)
            {
                item.Fav = !item.Fav;
            }
        });
        public ICommand DeleteCommand => new Command((o) =>
        {
            if (o != null && o is ItemModel item)
            {
                List.Remove(item);
            }
        });

        public MainPageViewModel()
        {
            Bind();
        }

        public ICommand DragStartingCommand => new Command((o) =>
        {
            
        });
        public ICommand DropCompletedCommand => new Command((o) =>
        {
            if (o != null && o is Label l)
            {
                var id = List.Max(i => i.Id) + 1;
                List.Add(new ItemModel
                {
                    Fav = true,
                    Name = l.Text,
                    Image = $"https://picsum.photos/id/{id}/200/300?grayscale&blur=2",
                    Id = id
                });
            }
        });
        public ICommand DragOverCommand => new Command((o) =>
        {
            
        });
        public ICommand DropCommand => new Command((o) =>
        {
            
        });
    }
}