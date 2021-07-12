using System;
using MusicPorts;

namespace ExplicitArchitecture.TuneSearchExample.MockCore
{
    public class TrackEntity : ITrackEntity
    {
        public string ArtistName { get; set; }
        public string CollectionName { get; set; }
        public string TrackName { get; set; }
        public int TrackNumber { get; set; }
        public int DiscNumber { get; set; }
        public Uri ArtworkUrl { get; set; }
        public int CompareTo(ITrackEntity other)
        {
            if (!CollectionName.Equals(other.CollectionName)) return CollectionName.CompareTo(other.CollectionName);
            return DiscNumber != other.DiscNumber ? ((int)DiscNumber).CompareTo(other.DiscNumber) : ((int)TrackNumber).CompareTo(other.TrackNumber);
        }
    }
}