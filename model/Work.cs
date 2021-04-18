using System;
using System.Collections.Generic;
using System.Text;

namespace MinClick
{
    /// <summary>
    /// Класс работы
    /// </summary>
    public class Work
    {
        public int id { get; set; }
        public string name { get; set; }
        public string time { get; set; }
        public List<int> category { get; set; }
        public DateTime? start { get; set; }
        public DateTime? stop { get; set; }
        public Work parent { get; set; }
        public List<Work> childs { get; set; }
    }
}
