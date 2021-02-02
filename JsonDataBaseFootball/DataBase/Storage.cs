using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDataBaseFootball.DataBase
{
    public static class Storage
    {
        public static void Write(string stringToWrite, string fileAddress)
        {
            using (StreamWriter file = new StreamWriter(fileAddress, false, System.Text.Encoding.Default))
            {
                file.WriteLine(stringToWrite);
                file.Close();
            }
        }
        public static string Read(string fileAddress)
        {
            using (StreamReader file = new StreamReader(fileAddress))
            {
                string result = file.ReadToEnd();
                file.Close();
                return result;
            }
        }
    }
}
