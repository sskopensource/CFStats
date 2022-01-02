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
        private bool _problemExpanded;

        public bool ProblemExpanded
        {
            get
            {
                return _problemExpanded;
            }
            set
            {
                _problemExpanded = value;
                OnCurrentViewModelChanged();
            }
        }

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
           string AccentColor= "{x:Null}";
           string DefaultColor = "{x:Null}";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetNavTabFontColor(NAVTAB navTab)
        {
            string AccentColor = "#53A6FA";
            string DefaultColor = "#7d99b5";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetNavTabHoverFontColor(NAVTAB navTab)
        {
            string AccentColor = "#53A6FA";
            string DefaultColor = "#9eb3c7";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetNavTabHoverBackgroundColor(NAVTAB navTab)
        {
            string AccentColor ="{x:Null}";
            string DefaultColor ="#2D3642";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetExpanderFontColor()
        {
            string AccentColor = "#53A6FA";
            string DefaultColor = "#7d99b5";

            if (ProblemExpanded) return AccentColor;
            return DefaultColor;
        }

        public string GetExpanderHoverFontColor()
        {
            string AccentColor = "#53A6FA";
            string DefaultColor = "#9eb3c7";

            if (ProblemExpanded) return AccentColor;
            return DefaultColor;
        }

        public string GetExpanderBackgroundColor()
        {
            string AccentColor = "{x:Null}";
            string DefaultColor = "{x:Null}";

            if (ProblemExpanded) return AccentColor;
            return DefaultColor;
        }

        public string GetExpanderHoverBackgroundColor()
        {
            string AccentColor = "{x:Null}";
            string DefaultColor = "#2D3642";

            if (ProblemExpanded) return AccentColor;
            return DefaultColor;
        }

        public string GetNavTabBorderColor(NAVTAB navTab)
        {
            string AccentColor = "#53A6FA";
            string DefaultColor = "{x:Null}";

            if (navTab == CurrentTab) return AccentColor;
            return DefaultColor;
        }

        public string GetExpanderBorderColor()
        {
            string AccentColor = "#53A6FA";
            string DefaultColor = "{x:Null}";

            if (ProblemExpanded) return AccentColor;
            return DefaultColor;
        }

    }
}
