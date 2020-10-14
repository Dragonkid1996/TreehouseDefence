using System;

namespace TreehouseDefense
{
    class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 2;
        public BasicInvader(Path path) : base(path)
        {

        }

        public static implicit operator BasicInvader(StrongInvader v)
        {
            throw new NotImplementedException();
        }
    }
}
