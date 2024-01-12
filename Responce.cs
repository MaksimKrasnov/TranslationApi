using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Language
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    public class Data
    {
        public Language[] Languages { get; set; }
    }

    public class GetLanguage
    {
        public Data Data { get; set; }
    }
    public class DataDTO
    {
        public string status { get; set; }
        public DataObject data { get; set; }
    }
    public class DataObject
    {
        public string TranslatedText { get; set; }
    }
}
