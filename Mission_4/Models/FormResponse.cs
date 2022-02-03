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
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Year.")]
        public uint Year { get; set; }
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Director.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Hey! You need to enter a valid response for Rating.")]
        public string Rating { get; set; }
        public string Edit { get; set; }

        public string Lent { get; set; }

        public string Notes { get; set; }

        //Build a foreign key relationship
        public int CategoryId { get; set; }
        public Category Category { get; set; } // This pair of things together (the primary key in the other table paired with an instance of that type) creates a foreign key relationship in the table

    }
}
