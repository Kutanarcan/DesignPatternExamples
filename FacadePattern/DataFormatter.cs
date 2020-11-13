using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class DataFormatter
    {
        public string SaveFormat(SomeData data)
        {
            string format = $"{data.dataName},{data.dataPath}";
            Console.WriteLine("Data Formatted to SaveFormat");

            return format;
        }

        public SomeData LoadFormat(string format)
        {
            SomeData someData = new SomeData();

            string[] datas = format.Split(',');

            someData.dataName = datas[0];
            someData.dataPath = datas[1];

            Console.WriteLine("Data DeFormatted to LoadFormat");
            return someData;
        }
    }

    public struct SomeData
    {
        public string dataName;
        public string dataPath;
    }
}
