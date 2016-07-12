namespace SareenaCars.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Contracts;
    using Misc;

    public abstract class MovingObject : IMoveable, IDrawable, IGameObject
    {
        protected MovingObject(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        protected Position Position { get; set; }

        public int Id
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

        public ConsoleColor Color
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

        public int Width { get; private set; }

        public int Height { get; private set; }

        public abstract void ChangePosition();

        public abstract string Draw();
    }
}
