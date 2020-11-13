using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class FileHandler
    {
        List<string> datas;

        public FileHandler()
        {
            datas = new List<string>();
        }

        public void SaveToFile(string data)
        {
            Console.WriteLine("Datas Saved To File");
            //Do file saving 
        }

        public List<string> LoadFromFile(string path)
        {
            datas.Clear();
            Console.WriteLine("Datas Loaded From File");
            //Do file loading

            //Test
            datas.Add("SomeName,C:/SomeData");
            datas.Add("SomeName2,C:/SomeData2");
            datas.Add("SomeName3,C:/SomeData3");
            //Test

            return datas;
        }
    }
}
