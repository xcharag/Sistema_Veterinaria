using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vet_la_finca.Core;

namespace Vet_la_finca.MWM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {

        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand VentasViewCommand { get; set; }

        public RelayCommand BanosViewCommand { get; set; }


        public HomeViewModel HomeVm { get; set; }

        public VentasViewModel VentasVm { get; set; }

        public BanosViewModel BanosVm { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; onpropertychanged(); }
        }

        public MainViewModel() 
        {
            HomeVm = new HomeViewModel();
            VentasVm = new VentasViewModel();
            BanosVm = new BanosViewModel();
            CurrentView = HomeVm;

            HomeViewCommand = new RelayCommand(o => { CurrentView = HomeVm; });

            VentasViewCommand = new RelayCommand(o => { CurrentView = VentasVm; });

            BanosViewCommand = new RelayCommand(o => { CurrentView = BanosVm; });
        }
    }
}
