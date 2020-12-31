using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Entities
{
    /// <summary>
    /// نویسنده ها
    /// </summary>
    public class Writer
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
        /// نام خانوداگی
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// نام مستعار  
        /// </summary>
        public string SureName { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }


    }
}
