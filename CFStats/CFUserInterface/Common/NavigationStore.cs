using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Common
{
    public class NavigationStore
    {
        private ViewModelBase _currentViewModel;
        private NAVTAB _currentTab;

        public ViewModelBase CurrentViewModel
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        public NAVTAB CurrentTab
        {
            get
            {
                return _currentTab;
            }
            set
            {
                _currentTab = value;
                OnCurrentViewModelChanged();
            }
        }

        public event Action CurrentViewModelChanged;

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }

        public string GetNavTabBackgroundColor(NAVTAB navTab)
        {
           string AccentColor= "#FF8000FF";
           string DefaultColor = "White";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetNavTabFontColor(NAVTAB navTab)
        {
            string AccentColor = "White";
            string DefaultColor = "Black";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetNavTabHoverColor(NAVTAB navTab)
        {
            string AccentColor = "#FF8000FF";
            string DefaultColor = "#EDEDED";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }
    }
}
