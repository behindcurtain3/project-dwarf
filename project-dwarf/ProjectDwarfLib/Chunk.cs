using System.Collections.Generic;

namespace ProjectDwarfLib
{
    public class Chunk
    {
        public static readonly int Width = 7;
        public static readonly int Height = 7;
        public static readonly int Depth = 7;

        public Dictionary<Location, Block> Data { get; private set; } = new Dictionary<Location, Block>();


    }
}
