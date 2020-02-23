using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Photo_Metadata_Organizer.Models
{
    public class PhotoContext : DbContext
    {

        public DbSet<Photo> Photos { get; set; }
        public DbSet<User> Users { get; set; }
    }
}





    
    
    