using System;
using System.Collections.Generic;

namespace dojoSurvey.Models
{
    public class User
    {
        public string Name { get; set; }
        public List<string> DojoLocations { get; set; }
        public List<string> FavoriteLanguage { get; set; }
        public string Comment { get; set; }
        public string FullName()
        {
            return Name;
        }
    }
}