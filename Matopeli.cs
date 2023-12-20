using Raylib_CsLo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Matopeli
{
    public class Matopeli
    {


        enum GameState
        {
            Start,
            Play,
            Pause,
            Options,
            ScoreScreen,
            GameOptions
        }

        int window_width = 640;
        int window_height = 720;

        GameState state;

        Player player;
        List<Berry> berries;
        MainMenu mainMenu;
        OptionsMenu optionsMenu;
        PauseMenu pauseMenu;

        //Pelaajan muuttujat



        //Marjan muuttujat



        //Muut muuttujat


        public void Run()
        {
            Init();
            GameLoop();
        }

        /// <summary>
        /// Luo pelille ikkunan ja lataa kartan, kuvat ja äänet
        /// 
        /// yhdistää muitten luokkien eventit methodeihin
        /// </summary>
        void Init()
        {
            Raylib.InitWindow(window_width, window_height, "Matopeli");

            state = GameState.Start;   
            
            
        }

        /// <summary>
        /// Resetoi pelin eli luo uuden pelaajan, marjat ja resetoi scoren
        /// </summary>
        void Reset()
        {
            player = new Player();


            berries = new List<Berry>();
        }

        /// <summary>
        /// Pelin looppi mitä pelaamisen aikana näkyy esim. pelin, main menu, pause menu, options menu, Score Screen.
        /// </summary>
        void GameLoop()
        {
            switch (state)
            {
                case GameState.Start:
                    
                    break;


                case GameState.Play:
                    
                    break;


                case GameState.Pause:

                    break;


                case GameState.Options:

                    break;

                case GameState.GameOptions:

                    break;

                case GameState.ScoreScreen:

                    break;
            }
        }

        /// <summary>
        /// Sisältää kaikki eri Update methodit 
        /// </summary>
        void Update()
        {
            UpdatePlayer();
            

           
        }        

        /// <summary>
        /// pelaajan liikkuminen ja pitää sen kentän rajojen sisällä
        /// </summary>
        void UpdatePlayer()
        {
            
        }
        /// <summary>
        /// Pitää huolen marjo
        /// </summary>
        void UpdateBerries()
        {

        }
        /// <summary>
        /// Piirtää kaiken tarpeellisen eli esim. pelaajan ja marjat 
        /// </summary>
        void Draw()
        {
            player.Draw();

            foreach (Berry berry in berries)
            {
                berry.Draw();
            }

        }
        /// <summary>
        /// Luo marjoja satunnaisiin paikkoihin
        /// </summary>
        void CreateBerry()
        {
            
        }
        /// <summary>
        /// Päivittää Scoren
        /// </summary>
        void ScoreUpdate()
        {

        }
        /// <summary>
        /// Piirtää scoren näytölle
        /// </summary>
        void ScoreDraw()
        {

        }
        /// <summary>
        /// kattoo että osuuko pelaaja marjoihin
        /// </summary>
        void CheckCollision()
        {

        }

        private void OnBackToGamePressed(object sender, EventArgs e)
        {
            state = GameState.Play;


        }

        private void OnBackToMainMenuPressed(object sender, EventArgs e)
        {
            state = GameState.Start;


        }
        private void OnOptionsPressed(object sender, EventArgs e)
        {
            state = GameState.Options;


        }

        private void OnMainMenuStartPressed(object sender, EventArgs e)
        {
            state = GameState.Play;


        }

        private void OnPausePressed(object sender, EventArgs e)
        {
            state = GameState.Pause;


        }

        private void OnMainMenuOptionsPressed(object sender, EventArgs e)
        {
            state = GameState.Options;


        }

        private void OnOptionsMenuBackPressed(object sender, EventArgs e)
        {
            state = GameState.Pause;

        }

        private void OnOptionsBackToMainMenuPressed(object sender, EventArgs e)
        {
            state = GameState.Start;

        }

        private void OnOptionsMenuGameSettingsPressed(object sender, EventArgs e)
        {
            state = GameState.Options;
        }

        public void OnRestartPressed(object sender, EventArgs e)
        {
            state = GameState.Play;
        }

        public void OnBackPressed(object sender, EventArgs e)
        {
            state = GameState.Play;
        }

    }
}
