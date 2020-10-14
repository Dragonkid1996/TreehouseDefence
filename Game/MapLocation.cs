namespace TreehouseDefense
{
	class MapLocation : Point
	{
		public MapLocation(int x, int y, Map map) : base(x, y)
        {
			if (!map.OnMap(this))
            {
				throw new OutOfBoundsException(this + "is out of the boundaries of the map");
            }
        }

		public bool InRangeOf(MapLocation location, int range)
        {
			return DistanceTo(location.X, location.Y) <= range;
        }
	}
}
