using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MbmStore.Models
{
    public class Track
    {
        private TimeSpan length;

        // Properties
        public string Title
        {
            get;
            set;
        }

        public string Composer
        {
            get;
            set;
        }
        public TimeSpan Length
        {
            get;
            set;
        }

        // Constructor
        // Used for creating the Track objects
        public Track()
        {
        }
        public Track(string title, string composer, TimeSpan length)
        {
            this.Composer = composer;
            this.Title = title;
            this.Length = this.length;
        }
    }
}