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
        public List<string> DojoLocation { get; set; }

        [Required]
        public List<string> FavoriteLanguage { get; set; }

        [MinLength(20)]
        public string Comment { get; set; }
        public string FullName()
        {
            return Name;
        }
        public string FullComment()
        {
            return Comment;
        }
        public List<string> Location()
        {
            return DojoLocation;
        }
        public List<string> Language()
        {
            return FavoriteLanguage;
        }
    }
}