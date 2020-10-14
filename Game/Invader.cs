namespace TreehouseDefense
{
    abstract class Invader : IInvader
    {
        private readonly Path _path;
        public abstract int Health { get; protected set; }

        protected virtual int StepSize { get; } = 1;
        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        private int _pathStep = 0;
        public MapLocation Location => _path.GetLocationAt(_pathStep);
        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor)
        {
            System.Console.WriteLine("Shot at and hit an invader!");
            Health -= 1;
        }
    }
}
