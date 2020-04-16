using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RanobeHub.Models
{
    public class TranslatedText
    {
        [Key]
        public int? Id { get; set; }
        public DateTime RealeseDate { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }

        public int? ChapterId { get; set; }
        public Chapter Chapter { get; set; }
    }
}
