using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //Τα παρακατω ονομαζονται-Data Notations
        [Display(Name = "Publication Date")]//decoration to properties ακριβως απο πανω
        [DataType(DataType.Date)] // αλλαζουμε την εμφανιση της ωρας
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
    }
}