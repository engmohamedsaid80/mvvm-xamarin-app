using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApp.Models
{
    public class QuotesRestModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public DateTime date { get; set; }
    }
}
