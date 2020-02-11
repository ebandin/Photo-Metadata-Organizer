using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Photo_Metadata_Organizer.Models
{
    public class Photo
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public Aperature Aperature { get; set; }
        public ISO ISO { get; set; }
        public FocalLength FocalLength { get; set; }

        public Photo()
        {
            ID = nextId;
            nextId++;
        }

    }
}
