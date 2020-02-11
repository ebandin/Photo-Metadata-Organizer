using System;
using System.Collections.Generic;
using Photo_Metadata_Organizer.Models;

namespace Photo_Metadata_Organizer.ViewModels
{
    public class BaseViewModel
    {
        // All columns, for display
        public List<PhotoField> Columns { get; set; }

        // The column to search, defaults to all
        public PhotoField Column { get; set; } = PhotoField.All;

        // View title 
        public string Title { get; set; } = "";

        public BaseViewModel()
        {
            Columns = new List<PhotoField>();

            foreach (PhotoField enumVal in Enum.GetValues(typeof(PhotoField)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
