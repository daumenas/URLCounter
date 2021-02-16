using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace URLCounter
{
    class FileReader
    {
        public void ReadFromFile(string fileName)
        {
            var lines = File.ReadLines(fileName);
            foreach (var line in lines)
            {

            }
        }

        public void WriteToFile()
        {

        }

        public void WriteErrorsToFile()
        {

        }
    }
}
