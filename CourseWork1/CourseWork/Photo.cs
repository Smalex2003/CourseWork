using System;
using System.Collections.Generic;
using System.Windows.Controls;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace CourseWork
{
    public partial class Photo
    {
        public long Id { get; set; }
        public long Size { get; set; }
        public string Format { get; set; }
        public string Name { get; set; }
        public string AddTime { get; set; }
        public string Photo1 { get; set; }
        public long UserId { get; set; }
        public long? PlaceOfPhotoId { get; set; }
        public long? AuthorOfPhotoId { get; set; }
        
        public virtual AuthorOfPhoto AuthorOfPhotoNavigation { get; set; }
        public virtual PlaceOfPhoto PlaceOfPhoto { get; set; }
        public virtual User User { get; set; }
        public virtual AuthorOfPhoto AuthorOfPhoto { get; set; }
        public virtual PlaceOfPhoto PlaceOfPhotoNavigation { get; set; }
    }
}
