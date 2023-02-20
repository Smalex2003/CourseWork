using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CourseWork
{
    public partial class AuthorOfPhoto
    {
        public AuthorOfPhoto()
        {
            Photo = new HashSet<Photo>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string Email { get; set; }
        public string City { get; set; }

        public virtual Photo IdNavigation { get; set; }
        public virtual ICollection<Photo> Photo { get; set; }
    }
}
