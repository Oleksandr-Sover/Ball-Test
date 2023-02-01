using UnityEngine;

namespace BallTest.GameLogic
{
    public class GamePlaybackController : MonoBehaviour
    {
        public static bool isPauseGame;

        public static void Pause()
        {
            Time.timeScale = 0;
            isPauseGame = true;
        }

        public static void Play()
        {
            Time.timeScale = 1;
            isPauseGame = false;
        }
    }
}