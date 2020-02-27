using System;
using System.Collections.Generic;
using System.Text;

namespace dataGrid
{
    class PersonData
    {
        public enum Gender
        {
            Male,
            Famale
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool IsSubscribedToNewsleter { get; set; }
        public Uri Website { get; set; }
        public Gender Sex { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
