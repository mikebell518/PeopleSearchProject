using System;
using System.ComponentModel.DataAnnotations;

namespace PeopleSearch.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public string Interests { get; set; }

        [Required]
        public string ImgPath { get; set; }
    }
}