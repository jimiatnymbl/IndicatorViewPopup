using System;
using System.Collections.Generic;
using System.Text;

namespace IndicatorViewPopup.ViewModels
{
    public class PopupViewModel : ViewModel
    {
        private int count;
        public int Count
        {
            get => count;
            set => Set(ref count, value);
        }

        private int position;
        public int Position
        {
            get => position;
            set => Set(ref position, value);
        }

        public PopupViewModel()
        {
            Count = 5;
            Position = 3;
        }
    }
}
