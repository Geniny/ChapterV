using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RanobeHub.Models
{
    public class Book
    {
        [Key]
        public int? Id { get; set; }
        public string OriginalName { get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }
        public string Image { get; set; }
        public int ChaptersCount { get; set; }
        public int TranslatedChaptersCount { get; set; }
        public string Description { get; set; }
        public List<Chapter> Chapters { get; set; }
        public Book()
        {
            this.Chapters = new List<Chapter>();
        }
    }
}
