using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCBook.Models
{
    [Table("Book")]
    public class Book
    {
        public int Id { get; set; }
        [Required(ErrorMessage="The Name field is required.")]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        [DisplayName("Books name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter an Author")]
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "The field Author must be a string with a maximum length of 50.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "The number of pages is required")]
        [Range(100,10000, ErrorMessage ="The field PagesNumber must be between 100 and 10.000")]
        [DisplayName("Number of pages")]
        public int PagesNumber { get; set; }
        [Required(ErrorMessage = "Please enter a publisher")]
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Publisher { get; set; }
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage ="Publication Date field is required.")]
        [RegularExpression(@"^\d{4}(\-|\/|\.)\d{1,2}\1\d{1,2}$", ErrorMessage ="Invalid date format. Try YYYY-MM-DD")]
        [DisplayName("Date of Publication")]
        public string PublicationDate { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Content { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        [NotMapped]
        [Compare("Price", ErrorMessage = "'PriceConfirm' and 'Price' do not match.")]
        public decimal PriceConfirm { get; set; }
    }
}