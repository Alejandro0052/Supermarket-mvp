using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.View
{
    internal class IProvidersView
    {
        public Action<object?, EventArgs> SearchEvent { get; set; }
        public Action<object?, EventArgs> SearchValue { get; set; }
        public Action<object?, EventArgs> AddNewEvent { get;  set; }
        public Action<object?, EventArgs> EditEvent { get; set; }
        public Action<object?, EventArgs> DeleteEvent { get; set; }
        public Action<object?, EventArgs> SaveEvent { get; set; }
        public Action<object?, EventArgs> CancelEvent { get; set; }
        public string ProviderId { get; internal set; }
        public string ProviderName { get; internal set; }
        public string ProviderObservation { get; internal set; }

        //   string ProviderId { get; set; }
        // string ProviderName { get; set; }
        //string ProviderObservation { get; set; }
        // string SearchValue { get; set; }
        //bool IsEdit { get; set; }
        //bool IsSuccesful { get; set; }
        //string Menssage { get; set; }

        /*   event EventHandler SearchEvent;
           event EventHandler AddNewEvent;
           event EventHandler EditEvent;
           event EventHandler DeleteEvent;
           event EventHandler SaveEvent;
           event EventHandler CancelEvent;
        */
        internal void SetProvidersListBildingSource(BindingSource providersBindingSource)
        {
            throw new NotImplementedException();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }

        /*
        void SetProvidersListBildingSource(BindingSource providersList);
        void Show();
        */

    }
}
