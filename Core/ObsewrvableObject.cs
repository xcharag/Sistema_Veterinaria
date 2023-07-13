using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Vet_la_finca.Core
{
    internal class ObsewrvableObject : INotifyPropertyChanged //This Inotify is for updating the UI when biding
    {
        public event PropertyChangedEventHandler? PropertyChanged; //This implements the PropertyChanged method

        protected void onpropertychanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
