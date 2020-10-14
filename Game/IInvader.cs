namespace TreehouseDefense
{
    interface IMappable
    {
        MapLocation Location { get; }
    }

    interface IMoveable
    {
        void Move();
    }

    interface IInvader : IMappable, IMoveable
    {
        bool HasScored { get; }
        int Health { get; }
        bool IsNeutralized { get; }
        bool IsActive { get; }               
        
        void DecreaseHealth(int factor);
    }
}
