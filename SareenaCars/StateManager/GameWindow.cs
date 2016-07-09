namespace SareenaCars.StateManager
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enumerations;

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
                    sb.AppendLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sb.AppendLine("+----------------------------    **       **          *         ***************  **            **  --------------------------+");
                    sb.AppendLine("+----------------------------   ****     ****        ***          ***********    ****          **  --------------------------+");
                    sb.AppendLine("+----------------------------   ** **   ** **       ** **             ***        **  **        **  --------------------------+");
                    sb.AppendLine("+----------------------------   **  ** **  **      **   **            ***        **    **      **  --------------------------+");
                    sb.AppendLine("+----------------------------   **   ***   **     *********           ***        **      **    **  --------------------------+");
                    sb.AppendLine("+----------------------------   **    *    **    ***********          ***        **        **  **  --------------------------+");
                    sb.AppendLine("+----------------------------   **         **   **         **     ***********    **          ****  --------------------------+");
                    sb.AppendLine("+----------------------------   **         **  **           **  ***************  **            **  --------------------------+");
                    sb.AppendLine("+----------------------------------------------------------------------------------------------------------------------------+");
                    sb.AppendLine("+----------------------------------------------------------------------------------------------------------------------------+");
                    sb.AppendLine("+--    ***********         *         *************    ***************  ***************  **            **         *         --+");
                    sb.AppendLine("+--  ********             ***        **           **  ***************  ***************  ****          **        ***        --+");
                    sb.AppendLine("+--    ******            ** **       **           **  **               **               **  **        **       ** **       --+");
                    sb.AppendLine("+--     *******         **   **      *************    ***************  ***************  **    **      **      **   **      --+");
                    sb.AppendLine("+--        ****        *********     **        **     ***************  ***************  **      **    **     *********     --+");
                    sb.AppendLine("+--        *******    ***********    **         **    **               **               **        **  **    ***********    --+");
                    sb.AppendLine("+--      *********   **         **   **          **   ***************  ***************  **          ****   **         **   --+");
                    sb.AppendLine("+--  ***********    **           **  **           **  ***************  ***************  **            **  **           **  --+");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                    -------------------------------------------------                                       +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                        Play Game       (ENTER)                                             +");
                    sb.AppendLine("+                                                        HighScore       (SPACE)                                             +");
                    sb.AppendLine("+                                                          Quit           (ESC)                                              +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                    -------------------------------------------------                                       +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine(sb.ToString());
                    break; 
                case StateType.Play:
                    sb.AppendLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                  PLAYING                                                                   +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                       _________                                                                     +");
                    sb.AppendLine("+                                                       |       |                                                              +");
                    sb.AppendLine("+                                                       |       |                                                              +");
                    sb.AppendLine("+                                                       |       |                                                              +");
                    sb.AppendLine("+                                                       |_______|                                                                  +");
                    sb.AppendLine("+                                                        (|   |)                                                               +");
                    sb.AppendLine("+                                                         |___|                                                                   +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                           /-\\                                                           O                                 +");
                    sb.AppendLine("+                         [|   |]                                                         /|\\                               +");
                    sb.AppendLine("+                          |   |                                                          / \\                               +");
                    sb.AppendLine("+                         [|___|]                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("+                                                                                                                            +");
                    sb.AppendLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
                    Console.WriteLine(sb.ToString());
                    break;
                case StateType.HighScore:
                    Console.WriteLine(sb.ToString());
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


