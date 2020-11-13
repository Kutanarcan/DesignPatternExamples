using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern
{
    class DataHandlerFacade
    {
        FileHandler fileHandler;
        DataFormatter dataFormatter;
        List<SomeData> someDatas;

        public DataHandlerFacade()
        {
            fileHandler = new FileHandler();
            dataFormatter = new DataFormatter();
            someDatas = new List<SomeData>();
        }

        public void Save(SomeData someData)
        {
            //Need to Convert First and Write Later
            string format = dataFormatter.SaveFormat(someData);
            fileHandler.SaveToFile(format);
        }

        public List<SomeData> Load(string path)
        {
            someDatas.Clear();
            //Get datas from file.
            var datas = fileHandler.LoadFromFile(path);

            for (int i = 0; i < datas.Count; i++)
            {
                //Convert string format to SomeData format and add to the list.
                someDatas.Add(dataFormatter.LoadFormat(datas[i]));
            }

            return someDatas;
        }
    }
}
