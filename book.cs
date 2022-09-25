using System.ComponentModel.DataAnnotations;

namespace mvc_mine.Models
{
    public class book
    {
        [Display (Name =" Book Title")]
        [MaxLength(8) , ErrorMessage("the length must be between 8 to 5 letters") , MinLength(5) ]
        [Required]
        public string Title { get; set; }
        [Display(Name ="Book Price")]
        public int price { get; set; }
        [Display(Name ="Authors: ")]
        public string author { get; set; }
        [Display(Name = "Description: ")]
        public string description { get; set; }


    }
}
