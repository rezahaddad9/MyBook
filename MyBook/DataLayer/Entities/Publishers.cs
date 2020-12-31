using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Entities
{
    /// <summary>
    /// انتشارات    
    /// </summary>
    public class Publishers
    {
        public int Id{ get; set; }

        /// <summary>
        /// نام انتشاراتی
        /// </summary>
        public string Name{ get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description{ get; set; }

        /// <summary>
        /// لوگو
        /// </summary>
        public string Logo { get; set; }


    }
}
