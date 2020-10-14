namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        private static System.Random _random = new System.Random();
        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreaseHealth(int factor)
        {
            if (_random.NextDouble() < .5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a Shielded Invader but it sustained no damage!");
            }
        }
    }
}