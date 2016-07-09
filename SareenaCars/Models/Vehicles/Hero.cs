namespace SareenaCars.Models.Vehicles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Misc;
    using Constants;

    class Hero : MovingObject, IHero
    {
        private int lives;
        public Hero(int width, int height) : base(width, height)
        {
            this.Lives = ModelConstants.LivesDefault;
            this.Score = ModelConstants.MinScore;
            this.Position = new Position();
        }

        public int Lives
        {
            get
            {
                return this.lives;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Cannot have 0 or less lives!");
                }
                this.lives = value;
            }
        }

        public int Score
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public override void ChangePosition()
        {
            throw new NotImplementedException();
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}