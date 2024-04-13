﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp;
using Supermarket_mvp.Models;
using Supermarket_mvp.View;

namespace Supermarket_mvp.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SaveEvent += SearcPayMode;
            this.view.AddNewEvent += AddNewPayMode;
            this.view.EditEvent += LoadSelectPayModeToEdit;
            this.view.DeleteEvent += DeleteSelelctedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancellEvent += CancelAction;

           // this.view.SerPayModeListBildingSource(payModeBindingSource);
            loadAllPayModeList();
            this.view.Show();
        }

        private void loadAllPayModeList()
        {
            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeleteSelelctedPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LoadSelectPayModeToEdit(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearcPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                payModeList = repository.GetByValue(this.view.SearchValue);

            }
            else
            {
                payModeList = repository.GetAll();
            
            }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
