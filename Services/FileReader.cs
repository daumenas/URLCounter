using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using URLCounter.Dto;

namespace URLCounter
{
    class FileReader: IFileReader
    {
        private readonly IRequestSender _requestSender;

        public FileReader(IRequestSender requestSender)
        {
            _requestSender = requestSender;
        }

        public async void ReadFromFile(string fileName)
        {
            var lines = File.ReadLines("C:/Users/daumi/source/repos/URLCounter/" + fileName);
            foreach (var line in lines)
            {
                var changes = await _requestSender.SendRequest(line);
                if (changes.Error != null)
                {
                    WriteErrorsToFile(changes);
                }
                else
                {
                    WriteToFile(changes);
                }
            }
        }

        public void WriteToFile(GetRequestDto changes)
        {

        }

        public void WriteErrorsToFile(GetRequestDto changes)
        {

        }
    }
}
