using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.View
{
    internal interface IMainView
    {
        int ShowProvidersView { get; set; }

        event EventHandler ShowPayModeView;
        event EventHandler ShowProductView;
        event EventHandler ShowCustomerView;
        //Los demas
    }
}
