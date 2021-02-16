using System;
using System.Net;
using System.Net.Http;

namespace URLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
                IRequestSender requestSender = new RequestSender();
                IFileReader fileReader = new FileReader(requestSender);

                fileReader.ReadFromFile("test.txt");
        }
    }
}
