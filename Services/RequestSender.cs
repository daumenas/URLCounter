using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using URLCounter.Dto;

namespace URLCounter
{
    public class RequestSender : IRequestSender
    {
        public RequestSender()
        {
        }

        public async Task<GetRequestDto> SendRequest(string fileName)
        {
            GetRequestDto test = new GetRequestDto();
            try
            {
                string html = string.Empty;
                string url = @fileName;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.AutomaticDecompression = DecompressionMethods.GZip;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    test.ContentLength = response.ContentLength;
                    test.StatusCode = response.StatusCode;
                    test.Date = response.Headers.Get("Date");
                    test.Url = fileName;
                }

                return test;
            }
            catch (Exception e)
            {
                test.Error = e.ToString();
                test.Url = fileName;
            }

            return test;
        }
    }
}