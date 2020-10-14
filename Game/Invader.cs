using System.Dynamic;

namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        public int Health { get; private set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        private int _pathStep = 0;
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += 1;

        public virtual void DecreaseHealth(int factor)
        {
            System.Console.WriteLine("Shot at and hit an invader!");
            Health -= 1;
        }
    }
}
