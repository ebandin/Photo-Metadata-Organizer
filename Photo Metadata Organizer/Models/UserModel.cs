using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace Photo_Metadata_Organizer.Models
{
    [Table("AspNetUsers")]
    public class User
    {
        public int Id { get; set; }


        [Required]
        public string UserName { get; set; }


        [DataType(DataType.EmailAddress)]
        public EmailAddressAttribute Email { get; set; }

    }
}
