using System;
using System.Collections.Generic;

namespace dojoSurvey.Models
{
    public class Survey
    {
        public string Name { get; set; }
        public List<string> DojoLocation { get; set; }
        public List<string> FavoriteLanguage { get; set; }
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