using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dojoSurvey.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public string DojoLocation { get; set; }

        [Required]
        public string FavoriteLanguage { get; set; }

        
        [MinLength(20)]
        public string Comment { get; set; }

        public List<string> DojoLocations {get; set;}
        public List<string> FavoriteLanguages {get; set; }
        public string FullName()
        {
            return Name;
        }
        public string FullComment()
        {
            return Comment;
        }
        public string Location()
        {
            return DojoLocation;
        }
        public string Language()
        {
            return FavoriteLanguage;
        }
    }
}