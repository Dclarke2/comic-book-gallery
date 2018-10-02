using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBookGallery.Models
{
    public class ComicBook
    {
        public int Id { get; set; } //Unique ID to identify each comic.
        public string SeriesTitle { get; set; } //Represents title of series comic book is apart of. 
        public int IssueNumber { get; set; } //IssueNumber release
        public string DescriptionHtml { get; set; } //Description of comic book.
        public Artist[] Artists { get; set; } //Artists involved in created of comic.
        public bool Favorite { get; set; } //Indicates whether comic is a favorite or not.

        public string DisplayText
        {
            get         //String value to uniquely identify for our comic book users. Property will be ReadOnly.Accompolished by not setting a 'Setter'. 
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }

        //series-title-issuenumber.jpg <-- Shows structure 
        public string CoverImageFileName //Displays File name of comic book. 
        {
            get
            {
                //'Replace' replaces any spaces in series title with Hypens. First parameter is string to replace followed by what to replace with. 
                return SeriesTitle.Replace("", "-").ToLower() + "-" + IssueNumber + ".jpg";
            }
            
        }


    }
}