using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp.View
{
    internal interface IPayModeView
    {
        string PayModeId { get; set; }
        string PayModeName { get; set; }
        string PayModeObservación { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }   
        bool IsSuccesful { get; set; }
        string Mesage {  get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancellEvent;

        void SerPayModeListBildingSource(BindingSource payModeBindingSource);

        //    void SerPayModeListBildingSource(BindingSource payModeBindingSource);
        void SetPayModeListBildingSource(BindingSource payModeList);
        void Show();

    }
}
