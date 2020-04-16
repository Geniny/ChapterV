using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RanobeHub.Models
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public List<TranslatedText> TranslatedTexts { get; set; }
        public Chapter()
        {
            this.TranslatedTexts = new List<TranslatedText>();
        }
    }
}
