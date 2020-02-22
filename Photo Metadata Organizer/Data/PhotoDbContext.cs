using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Photo_Metadata_Organizer.Data.Migrations;

namespace Photo_Metadata_Organizer.Data
{
    public class PhotoDbContext : IdentityDbContext
    {
        public PhotoDbContext(DbContextOptions<PhotoDbContext> options)
            : base(options)
        { }

        public DbSet<PhotoField> Photo { get; set; }
    }
}

