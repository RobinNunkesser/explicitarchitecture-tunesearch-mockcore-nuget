using System.Collections.Generic;
using MusicPorts;

namespace ExplicitArchitecture.TuneSearchExample.MockCore
{
    public class CollectionEntity : ICollectionEntity
    {
        public string Name { get; set; }
        public List<ITrackEntity> Tracks { get; set; } = new List<ITrackEntity>();
    }
}