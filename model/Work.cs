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
        /// <summary>
        /// Идентификатор работы
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Название работы
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Общее время потраченное на выполнение работы в милисекундах
        /// </summary>
        public long time { get; set; }
        /// <summary>
        /// Список категорий куда входит работа
        /// </summary>
        public List<int> category { get; set; }
        /// <summary>
        /// Время начала выполнения работы
        /// </summary>
        public DateTime? start { get; set; }
        /// <summary>
        /// Время окончания выполнения работы
        /// </summary>
        public DateTime? stop { get; set; }
        /// <summary>
        /// ID работы которая является родительской
        /// </summary>
        public int parentId { get; set; }
        /// <summary>
        /// Список ID дочерних работ если такие есть, по умолчанию:???
        /// </summary>
        public List<int> childsId { get; set; }
    }
}
