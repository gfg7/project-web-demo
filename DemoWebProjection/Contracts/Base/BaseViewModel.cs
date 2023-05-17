using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebProjection.Contracts.Base
{
    internal abstract class BaseViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _error = string.Empty;
        
        public string Error => _error;
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual string this[string columnName]
        {
            get
            {
                OnPropertyChanged(columnName);

                return Error;
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
