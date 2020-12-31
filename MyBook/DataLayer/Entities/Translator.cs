using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    /// <summary>
    /// مترجم
    /// </summary>
    public class Translator
    {
        /// <summary>
        /// شناسه   
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}
