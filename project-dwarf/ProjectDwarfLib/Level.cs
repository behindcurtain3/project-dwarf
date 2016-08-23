using System.Collections.Generic;

namespace ProjectDwarfLib
{
    public class Level
    {
        public Dictionary<Location, Chunk> Chunks { get; private set; } = new Dictionary<Location, Chunk>();

        public Block GetBlockAtLocation(Location loc)
        {
            return GetChunkFromLocation(loc).Data[loc];
        }

        public Chunk GetChunkFromLocation(Location loc)
        {
            Location chunkLocation = new Location(loc.X / Chunk.Width, loc.Y / Chunk.Height, loc.Z / Chunk.Depth);

            return Chunks[chunkLocation];
        }
    }
}
