using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CourseWork
{
    public partial class User
    {
        public User()
        {
            Photo = new HashSet<Photo>();
        }

        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public long Storage { get; set; }
        public long MaxStorage { get; set; }

        public virtual ICollection<Photo> Photo { get; set; }
    }
}
