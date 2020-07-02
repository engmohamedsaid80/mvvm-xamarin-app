using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using QuotesApp.Models;
using System.Collections.ObjectModel;
using QuotesApp.Interfaces;

namespace QuotesApp.ViewModels
{
    public class QuotesViewModel : BaseViewModel
    {
        private IQuotesService _quotesService;
        public ObservableCollection<QuotesRestModel> QuotesList { get; set; }
        public QuotesViewModel(IQuotesService quotesService)
        {
            _quotesService = quotesService;

            QuotesList = new ObservableCollection<QuotesRestModel>();

            LoadQuotes();
        }
        private async void LoadQuotes()
        {
            var result = await _quotesService.GetQuotesAsync();

            foreach (QuotesRestModel q in result) QuotesList.Add(q);
        }
    }
}
