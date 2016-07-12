namespace SareenaCars.StateManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enumerations;
    using Constants;
    using Models.Vehicles;
    public class GameWindow     
    {
        //FIELDS
        private static GameWindow instance;
        private static StateType currentState = StateType.Main;
        private static object syncLock = new Object();

        //CONSTRUCTOR
        private GameWindow()
        {
            this.Hero = new Hero(ModelConstants.HeroWidth, ModelConstants.HeroHeight);
        }

        //PROPERTIES
        public static GameWindow Instance {
            get
            {
                if (instance == null)
                {
                    lock (syncLock)
                    {
                        if (instance == null)
                        {
                            instance = new GameWindow();
                        }
                    }
                }
                return instance;
            }
        }
        private static StateType CurrentState{ get; set; }
        public Hero Hero { get; set; }

        //METHODS
        public static void ChangeState(ConsoleKeyInfo type)
        {
            switch (type.Key)
            {
                case ConsoleKey.A:
                    currentState = StateType.Main;
                    break;
                case ConsoleKey.Enter:
                    currentState = StateType.Play;
                    break;
                case ConsoleKey.Spacebar:
                    currentState = StateType.HighScore;
                    break;
                case ConsoleKey.Escape:
                    currentState = StateType.Quit;
                    break;
                default:
                    //Exception???
                    break;
            }
            DrawState();
        }
        public static void DrawState()
        {
            var sb = new StringBuilder();
            
            Console.Clear();
            switch (currentState)
            {
                case StateType.Main:
                    Console.SetWindowSize(GlobalConstants.MainScreenWidth, GlobalConstants.MainScreenHeight);
                    Console.SetBufferSize(GlobalConstants.MainScreenWidth, GlobalConstants.MainScreenHeight);
                    sb.AppendFormat($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sb.AppendFormat($"+----------------------------    **       **          *         ***************  **            **  --------------------------+");
                    sb.AppendFormat($"+----------------------------   ****     ****        ***          ***********    ****          **  --------------------------+");
                    sb.AppendFormat($"+----------------------------   ** **   ** **       ** **             ***        **  **        **  --------------------------+");
                    sb.AppendFormat($"+----------------------------   **  ** **  **      **   **            ***        **    **      **  --------------------------+");
                    sb.AppendFormat($"+----------------------------   **   ***   **     *********           ***        **      **    **  --------------------------+");
                    sb.AppendFormat($"+----------------------------   **    *    **    ***********          ***        **        **  **  --------------------------+");
                    sb.AppendFormat($"+----------------------------   **         **   **         **     ***********    **          ****  --------------------------+");
                    sb.AppendFormat($"+----------------------------   **         **  **           **  ***************  **            **  --------------------------+");
                    sb.AppendFormat($"+----------------------------------------------------------------------------------------------------------------------------+");
                    sb.AppendFormat($"+----------------------------------------------------------------------------------------------------------------------------+");
                    sb.AppendFormat($"+--    ***********         *         *************    ***************  ***************  **            **         *         --+");
                    sb.AppendFormat($"+--  ********             ***        **           **  ***************  ***************  ****          **        ***        --+");
                    sb.AppendFormat($"+--    ******            ** **       **           **  **               **               **  **        **       ** **       --+");
                    sb.AppendFormat($"+--     *******         **   **      *************    ***************  ***************  **    **      **      **   **      --+");
                    sb.AppendFormat($"+--        ****        *********     **        **     ***************  ***************  **      **    **     *********     --+");
                    sb.AppendFormat($"+--        *******    ***********    **         **    **               **               **        **  **    ***********    --+");
                    sb.AppendFormat($"+--      *********   **         **   **          **   ***************  ***************  **          ****   **         **   --+");
                    sb.AppendFormat($"+--  ***********    **           **  **           **  ***************  ***************  **            **  **           **  --+");
                    sb.AppendFormat($"+                                                                                                                            +");
                    sb.AppendFormat($"+                                                                                                                            +");
                    sb.AppendFormat($"+                                    -------------------------------------------------                                       +");
                    sb.AppendFormat($"+                                                                                                                            +");
                    sb.AppendFormat($"+                                                        Play Game       (ENTER)                                             +");
                    sb.AppendFormat($"+                                                        HighScore       (SPACE)                                             +");
                    sb.AppendFormat($"+                                                          Quit           (ESC)                                              +");
                    sb.AppendFormat($"+                                                                                                                            +");
                    sb.AppendFormat($"+                                    -------------------------------------------------                                       +");
                    sb.AppendFormat($"+                                                                                                                            +");
                    sb.AppendFormat($"+                                                                                                                            +");
                    sb.AppendFormat($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.Write(sb.ToString());
                    break; 
                case StateType.Play:
                    Console.SetWindowSize(GlobalConstants.PlayScreenWidth, GlobalConstants.PlayScreenHeight);
                    Console.SetBufferSize(GlobalConstants.PlayScreenWidth, GlobalConstants.PlayScreenHeight);

                    //sb.AppendLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||_________||         ||         ||         +");
                    //sb.AppendLine($"+          |||       |||         ||         ||         +");
                    //sb.AppendLine($"+          |||       |||         ||         ||         +");
                    //sb.AppendLine($"+          |||       ||| => ENEMY||         ||         +");
                    //sb.AppendLine($"+          |||_______|||    TRUCK||         ||         +");
                    //sb.AppendLine($"+          || (|   |) ||         ||         ||         +");
                    //sb.AppendLine($"+          ||  |___|  ||     O   || => COIN ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||   /-\\   ||         ||         +");
                    //sb.AppendLine($"+          ||         || [|   |] ||         ||         +");
                    //sb.AppendLine($"+          ||         ||  |   |  || => HERO ||         +");
                    //sb.AppendLine($"+          ||         || [|___|] ||     CAR ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"+          ||         ||         ||         ||         +");
                    //sb.AppendLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    //sb.AppendLine($"+      LIVES:          SCORE:           HIGHSCORE:     +");
                    //sb.AppendLine($"+      {'♥'}                  0                10000       +");
                    //sb.AppendLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.Write(sb.ToString());
                    break;
                case StateType.HighScore:
                    Console.Write(sb.ToString());
                    break;
                case StateType.Quit:
                    Console.SetWindowSize(GlobalConstants.QuitScreenWidth, GlobalConstants.QuitScreenHeight);
                    Console.SetBufferSize(GlobalConstants.QuitScreenWidth, GlobalConstants.QuitScreenHeight);
                    sb.AppendFormat("      ___           ___           ___           ___");
                    sb.AppendFormat("\n     /  /\\         /  /\\         /__/\\         /  /\\ ");
                    sb.AppendFormat("\n    /  /:/_       /  /::\\       |  |::\\       /  /:/_   ");
                    sb.AppendFormat("\n   /  /:/ /\\     /  /:/\\:\\      |  |:|:\\     /  /:/ /\\");
                    sb.AppendFormat("\n  /  /:/_/::\\   /  /:/~/::\\   __|__|:|\\:\\   /  /:/ /:/");
                    sb.AppendFormat("\n /__/:/__\\/\\:\\ /__/:/ /:/\\:\\ /__/::::| \\:\\ /__/:/ /:/ /\\");
                    sb.AppendFormat("\n \\  \\:\\ /~~/:/ \\  \\:\\/:/__\\/ \\  \\:\\~~\\__\\/ \\  \\:\\/:/ /:/");
                    sb.AppendFormat("\n  \\  \\:\\  /:/   \\  \\::/       \\  \\:\\        \\  \\::/ /:/");
                    sb.AppendFormat("\n   \\  \\:\\/:/     \\  \\:\\        \\  \\:\\        \\  \\:\\/:/");
                    sb.AppendFormat("\n    \\  \\::/       \\  \\:\\        \\  \\:\\        \\  \\::/");
                    sb.AppendFormat("\n     \\__\\/         \\__\\/         \\__\\/         \\__\\/");
                    sb.AppendFormat("\n\n                     Thanks For Playing!!!\n");
                    sb.AppendFormat("\n       ___                        ___           ___");
                    sb.AppendFormat("\n      /  /\\          ___         /  /\\         /  /\\");
                    sb.AppendFormat("\n     /  /::\\        /__/\\       /  /:/_       /  /::\\");
                    sb.AppendFormat("\n    /  /:/\\:\\       \\  \\:\\     /  /:/ /\\     /  /:/\\:\\");
                    sb.AppendFormat("\n   /  /:/  \\:\\       \\  \\:\\   /  /:/ /:/_   /  /:/~/:/");
                    sb.AppendFormat("\n  /__/:/ \\__\\:\\  ___  \\__\\:\\ /__/:/ /:/ /\\ /__/:/ /:/___");
                    sb.AppendFormat("\n  \\  \\:\\ /  /:/ /__/\\ |  |:| \\  \\:\\/:/ /:/ \\  \\:\\/:::::/");
                    sb.AppendFormat("\n   \\  \\:\\  /:/  \\  \\:\\|  |:|  \\  \\::/ /:/   \\  \\::/~~~~");
                    sb.AppendFormat("\n    \\  \\:\\/:/    \\  \\:\\__|:|   \\  \\:\\/:/     \\  \\:\\");
                    sb.AppendFormat("\n     \\  \\::/      \\__\\::::/     \\  \\::/       \\  \\:\\");
                    sb.AppendFormat("\n      \\__\\/           ~~~~       \\__\\/         \\__\\/");
                    Console.WriteLine(sb.ToString());
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    //Again possible place for exception
                    Console.WriteLine(sb.ToString());
                    break;
            }
        }

    }
}


