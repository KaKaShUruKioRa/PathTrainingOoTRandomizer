
using PathTrainingOoTRandomizer.Models;

namespace PathTrainingOoTRandomizer.Managers
{
    public class GameManager
    {
        public Game Game;
        bool isInGame = false;

        public GameManager()
        {
            //Initialise tous les paramètres d'une Game
            this.Game = new Game();

            //Lance la Game jusqu'à ce que Game n'existe plus.
            StartGame();
        }

        // Démarre la Boucle de Jeu
        void StartGame()
        {
            Console.WriteLine(Game.World);

            this.CheckGameStatus();

            this.GameLoop();
        }

        // La Boucle de Jeu
        void GameLoop()
        {
            UInt128 operation = 0;
            UInt64 frame = 0;
            UInt32 second = 0;
            UInt16 minute = 0;

            while (isInGame)
            {
                operation++;

                if (operation % (3600*120) == 0)
                {
                    frame++;

                    if (frame % 60 == 0)
                    {
                        second++;

                        CheckGameStatus();

                        if (second % 60 == 0)
                        {
                            second = 0;
                            minute++;

                            if(minute % 4 == 0 && second % 33 == 0)
                                Game.World = null;

                        }
                    }
                }
            }

            Console.WriteLine(frame + " frames en " + minute + ":" + second);
        }

        // Vérifie que Le Monde et le Joueur Existe Toujours dans le Jeu
        void CheckGameStatus()
        {
            if (Game.World != null && Game.Player != null)
            {
                isInGame = true;
            }
            else
            {
                isInGame = false;
            }
        }
    }
}