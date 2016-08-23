namespace ProjectDwarfLib
{
    public class Location
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Z { get; set; } = 0;

        public Location() { }
        public Location(int x, int y, int z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        
        public void Offset(int x = 0, int y = 0, int z = 0)
        {
            this.X += x;
            this.Y += y;
            this.Z += z;
        }

        public static bool operator == (Location a, Location b)
        {
            if (System.Object.ReferenceEquals(a, b))
                return true;

            if ((object)a == null || (object)b == null)
                return false;

            return (a.X == b.X) && (a.Y == b.Y) && (a.Z == b.Z);
        }

        public override bool Equals(object obj)
        {
            Location other = obj as Location;
            if ((object)other == null)
                return false;

            return (X == other.X) && (Y == other.Y) && (Z == other.Z);
        }
        
        public static bool operator != (Location a, Location b) => !(a == b);
        public bool Equals(Location other) => (other == null) ? false : (X == other.X) && (Y == other.Y) && (Z == other.Z);
        public override int GetHashCode() => (X ^ Y) ^ Z;
        public override string ToString() => string.Format("{0}, {1}, {2}", X, Y, Z);
    }
}
