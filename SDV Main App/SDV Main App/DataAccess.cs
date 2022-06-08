using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV_Main_App
{
    class DataAccess
    {
        //Main Form Methods
        public void DeleteEntry(string currentIndex)
        {
            string tempFile = Path.GetTempFileName();
            string fileName = @"Tours.txt";
            string line = null;
            using (var sr = new StreamReader(fileName))
            using (var sw = new StreamWriter(tempFile))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.Contains(currentIndex))
                        sw.WriteLine(line);
                }
            }
            File.Delete(fileName);
            File.Move(tempFile, fileName);
        }



        //New Tour Form Methods
    }
}
