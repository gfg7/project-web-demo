using DemoWebProjection.Contracts.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebProjection.ViewModels
{
    internal class MapView : BaseViewModel
    {
        private bool _isUserVisible;

        public bool IsUserVisible { get => _isUserVisible; set => _isUserVisible = value; }


    }
}
