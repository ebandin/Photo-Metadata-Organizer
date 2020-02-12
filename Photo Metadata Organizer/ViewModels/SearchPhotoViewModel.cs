using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Photo_Metadata_Organizer.Models;

namespace Photo_Metadata_Organizer.ViewModels
{
    public class SearchPhotoViewModel : BaseViewModel
    {
        // TODO #7.1 - Extract members common to JobFieldsViewModel
        // to BaseViewModel

        // The search results
        public List<Photo> Photos { get; set; }

        // The search value
        [Display(Name = "Keyword:")]
        public string Value { get; set; } = "";


    }
}