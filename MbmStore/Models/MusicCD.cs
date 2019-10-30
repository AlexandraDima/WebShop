using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class MusicCD : Product
    {
        // Fields
        List<Track> tracks = new List<Track>();
        private TimeSpan getPlayingTime;

        // Properties
        public string Artist
        {
            get;
            set;
        }

        public string Publisher
        {
            get;
            set;
        }

        public string Label
        {
            get;
            set;
        }

        public short Released
        {
            get;
            set;
        }

        public List<Track> Tracks
        {
            get { return tracks; }
        }

        // Constructor
        // Used for creating the MusicCD objects
        public MusicCD()
        {
        }
        public MusicCD(int productId, string title, string artist, string publisher, decimal price, string ImageURL) :
        base(productId, title, price, ImageURL)
        {
            this.Artist = artist;
            this.Title = title;
            this.Publisher = publisher;
            this.ProductId = productId;
        }


        // Void method helps adding objects to a list.
        public void addTrack(Track track)
        {
            Tracks.Add(track);
        }

        // Method to calculate the total track length
        public TimeSpan GetPlayingTime(){
            var playingTimeSec = TimeSpan.FromSeconds(Tracks.Select(t => t.Length.TotalSeconds).Sum());
            return playingTimeSec;
        }


        }

    }
    
