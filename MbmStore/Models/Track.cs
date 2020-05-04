using System;

namespace MbmStore.Models
{
    public class Track
    {
        public int TrackId { get; set; }
        public string Title { get; set; }
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }

        public Track()
        {
        }

        public Track(string title, TimeSpan length)
        {
            Title = title;
            Length = length;
            Composer = "";
        }

        public Track(/*int trackId,*/ string title, TimeSpan length, string composer)
        {
            //TrackId = trackId;
            Title = title;
            Length = length;
            Composer = composer;
        }
    }
}