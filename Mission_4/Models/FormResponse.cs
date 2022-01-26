using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//My models page!
namespace Mission_4.Models
{
    public class FormResponse
    {
        [Key] //This will tell the program that the line below is the key
        [Required]
        public int FormId { get; set; } //Each table column needs a getter and setter
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public uint Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public string Edit { get; set; }

        public string Lent { get; set; }

        public string Notes { get; set; }
    }
}
