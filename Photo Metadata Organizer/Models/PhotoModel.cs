using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace Photo_Metadata_Organizer.Models
{
    [Table("PhotoField")]
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        public string PhotoName { get; set; }
         
        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }

        [Required]
        public int FocalLength { get; set; }

        [Required]
        public int ShutterSpeed { get; set; }

        [Required]
        public int Exposure { get; set; }

        [Required]
        public int ISO { get; set; }

        [Required]
        public int WhiteBalance { get; set; }

        public List<Photo> Photos { get; set; }

    }



    //public class Movie
    //{
    //    public int Id { get; set; }

    //    [StringLength(60, MinimumLength = 3)]
    //    [Required]
    //    public string Title { get; set; }

    //    [Display(Name = "Release Date")]
    //    [DataType(DataType.Date)]
    //    public DateTime ReleaseDate { get; set; }

    //    [Range(1, 100)]
    //    [DataType(DataType.Currency)]
    //    [Column(TypeName = "decimal(18, 2)")]
    //    public decimal Price { get; set; }

    //    [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
    //    [Required]
    //    [StringLength(30)]
    //    public string Genre { get; set; }

    //    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    //    [StringLength(5)]
    //    [Required]
    //    public string Rating { get; set; }
    //}


}
