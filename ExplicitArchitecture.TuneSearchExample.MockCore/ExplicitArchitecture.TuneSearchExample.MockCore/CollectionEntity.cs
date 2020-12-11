using System.Collections.Generic;
using ExplicitArchitecture.TuneSearchExample.Core.Ports;

namespace ExplicitArchitecture.TuneSearchExample.MockCore
{
    public class CollectionEntity : ICollectionEntity
    {
        public string Name { get; set; }
        public List<ITrackEntity> Tracks { get; set; }
    }
}