namespace SareenaCars.Models.Vehicles
{
    using System;
    using System.Text;
    using Misc;
    using Constants;

    public class Hero : MovingObject, IHero
    {
        private int lives;

        public Hero(int width, int height) : base(width, height)
        {
            this.Lives = ModelConstants.LivesDefault;
            this.Score = ModelConstants.MinScore;
            this.Position = new Position();
        }

        public Hero()
            : this(ModelConstants.StartPositionX, ModelConstants.StartPositionY)
        {
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

        public int Score { get; set; }//validation

        public override void ChangePosition()
        {
            ConsoleKeyInfo keyInfo;

            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        MoveHero(0, -1);
                        break;

                    case ConsoleKey.RightArrow:
                        MoveHero(1, 0);
                        break;

                    case ConsoleKey.DownArrow:
                        MoveHero(0, 1);
                        break;

                    case ConsoleKey.LeftArrow:
                        MoveHero(-1, 0);
                        break;
                }
            }
        }

        public static void MoveHero(int x, int y)
        {
            Position newHero = new Position()
            {
                //XAxis = Hero.X + x,
                //YAxis = Hero.Y + y
            };

            if (CanMove(newHero))
            {
                RemoveHero();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(newHero.XAxis, newHero.YAxis);
                Console.Write(" ");

                //Hero = newHero;
            }
        }

        static void RemoveHero()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            //Console.SetCursorPosition(Hero.X, Hero.Y);
            Console.Write(" ");
        }

        static bool CanMove(Position c)
        {
            if (c.XAxis < 0 || c.XAxis >= Console.WindowWidth)
            {
                return false;
            }
            if (c.YAxis < 0 || c.YAxis >= Console.WindowHeight)
            {
                return false;
            }

            return true;
        }

        

        public override string Draw()
        {
            Console.SetCursorPosition(this.Position.XAxis, this.Position.YAxis);
            return this.ToString();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("  /-\\");
            sb.AppendFormat("\n[|   |]");
            sb.AppendFormat("\n |   |");
            sb.AppendFormat("\n[|___|]");
            return base.ToString();
        }
    }
}