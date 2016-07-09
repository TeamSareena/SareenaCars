namespace SareenaCars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Constants;
    using StateManager;

    class Startup
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(GlobalConstants.screenWidth, GlobalConstants.screenHeight);

            
            while (true)
            {
                var key = Console.ReadKey();
                GameWindow.ChangeState(key);
            }
            
        }
    }
}
