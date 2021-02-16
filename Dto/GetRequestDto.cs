using System;
using System.Collections.Generic;
using System.Text;

namespace URLCounter.Dto
{
    public class GetRequestDto
    {
        public string Url { get; set; }
        public System.Net.HttpStatusCode StatusCode { get; set; }
        public long ContentLength { get; set; }
        public string Date { get; set; }
        public string Error { get; set; }
    }
}
