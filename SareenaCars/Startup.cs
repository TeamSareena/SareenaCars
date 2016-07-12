namespace SareenaCars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Constants;
    using StateManager;
    using Models.Vehicles;
    using Models;
    class Startup
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;
            Console.OutputEncoding = Encoding.Unicode;
            Console.Title = ("Sareena Cars");
            Console.ForegroundColor = ConsoleColor.Red;
            var hero = new Hero();
            var border = new Border(hero);

            while (true)
            {
                var key = Console.ReadKey();
                GameWindow.ChangeState(key);
                border.Print();
            }
            
        }
    }
}
