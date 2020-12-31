using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataLayer.Entities
{
    /// <summary>
    /// کتاب
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        /// <summary>
        /// نام کتاب
        /// </summary>
        public string BookName { get; set; }

        /// <summary>
        /// شابک
        /// </summary>
        public string Shabak { get; set; }

        /// <summary>
        /// نویسنده
        /// </summary>
        public int WriterId { get; set; }

        /// <summary>
        /// انتشاراتی
        /// </summary>
        public int PublisherId { get; set; }

        /// <summary>
        /// مترجم
        /// </summary>
        public int? TranslatorId { get; set; }

        /// <summary>
        /// تاریخ انتشار        
        /// </summary>
        public DateTime PublishDate { get; set; }

        //[ForeignKey("WriterId")]
        [ForeignKey(nameof(WriterId))]
        public virtual Writer Writer { get; set; }

        /// <summary>
        /// انتشارات
        /// </summary>
        [ForeignKey(nameof(PublisherId))]
        public virtual Publishers Publishers { get; set; }

        [ForeignKey(nameof(TranslatorId))]
        public virtual Translator Translator { get; set; }

    }
}
