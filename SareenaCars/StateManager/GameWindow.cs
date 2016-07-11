namespace SareenaCars.StateManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enumerations;
    using Constants;

    public class GameWindow     
    {
        private static GameWindow instance;
        private static StateType currentState = StateType.Main;
        private static object syncLock = new Object();

        private GameWindow()
        {

        }

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

        public static void ChangeState(ConsoleKeyInfo type)
        {
            switch (type.Key)
            {
                case ConsoleKey.A:
                    currentState = StateType.Main;
                    DrawState();
                    break;
                case ConsoleKey.Enter:
                    currentState = StateType.Play;
                    DrawState();
                    break;
                case ConsoleKey.Spacebar:
                    currentState = StateType.HighScore;
                    DrawState();
                    break;
                case ConsoleKey.Escape:
                    currentState = StateType.Quit;
                    DrawState();
                    break;
                default:
                    //Exception???
                    DrawState();
                    break;
            }
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
                    sb.AppendLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||_________||         ||         ||         +");
                    sb.AppendLine($"+          |||       |||         ||         ||         +");
                    sb.AppendLine($"+          |||       |||         ||         ||         +");
                    sb.AppendLine($"+          |||       ||| => ENEMY||         ||         +");
                    sb.AppendLine($"+          |||_______|||    TRUCK||         ||         +");
                    sb.AppendLine($"+          || (|   |) ||         ||         ||         +");
                    sb.AppendLine($"+          ||  |___|  ||     O   || => COIN ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||   /-\\   ||         ||         +");
                    sb.AppendLine($"+          ||         || [|   |] ||         ||         +");
                    sb.AppendLine($"+          ||         ||  |   |  || => HERO ||         +");
                    sb.AppendLine($"+          ||         || [|___|] ||     CAR ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"+          ||         ||         ||         ||         +");
                    sb.AppendLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sb.AppendLine($"+      LIVES:          SCORE:           HIGHSCORE:     +");
                    sb.AppendLine($"+      {'♥'}                  0                10000       +");
                    sb.AppendLine($"++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.Write(sb.ToString());
                    break;
                case StateType.HighScore:
                    Console.Write(sb.ToString());
                    break;
                case StateType.Quit:
                    /*
 *            ___           ___           ___           ___     
             /  /\         /  /\         /__/\         /  /\    
            /  /:/_       /  /::\       |  |::\       /  /:/_   
           /  /:/ /\     /  /:/\:\      |  |:|:\     /  /:/ /\  
          /  /:/_/::\   /  /:/~/::\   __|__|:|\:\   /  /:/ /:/_ 
         /__/:/__\/\:\ /__/:/ /:/\:\ /__/::::| \:\ /__/:/ /:/ /\
         \  \:\ /~~/:/ \  \:\/:/__\/ \  \:\~~\__\/ \  \:\/:/ /:/
          \  \:\  /:/   \  \::/       \  \:\        \  \::/ /:/ 
           \  \:\/:/     \  \:\        \  \:\        \  \:\/:/  
            \  \::/       \  \:\        \  \:\        \  \::/   
             \__\/         \__\/         \__\/         \__\/    
              ___                        ___           ___     
             /  /\          ___         /  /\         /  /\    
            /  /::\        /__/\       /  /:/_       /  /::\   
           /  /:/\:\       \  \:\     /  /:/ /\     /  /:/\:\  
          /  /:/  \:\       \  \:\   /  /:/ /:/_   /  /:/~/:/  
         /__/:/ \__\:\  ___  \__\:\ /__/:/ /:/ /\ /__/:/ /:/___
         \  \:\ /  /:/ /__/\ |  |:| \  \:\/:/ /:/ \  \:\/:::::/
          \  \:\  /:/  \  \:\|  |:|  \  \::/ /:/   \  \::/~~~~ 
           \  \:\/:/    \  \:\__|:|   \  \:\/:/     \  \:\     
            \  \::/      \__\::::/     \  \::/       \  \:\    
             \__\/           ~~~~       \__\/         \__\/    

                    Thanks For Playing!!!
 */

                    Console.WriteLine(sb.ToString());
                    break;
                default:
                    //Again possible place for exception
                    Console.WriteLine(sb.ToString());
                    break;
            }
        }

    }
}


