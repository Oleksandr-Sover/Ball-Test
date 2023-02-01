using UnityEngine;
using UnityEngine.SceneManagement;

namespace BallTest.UI
{
    public class GameStart : MonoBehaviour
    {
        public void PlayGame()
        {
            BallTest.GameLogic.GamePlaybackController.Play();
            BallTest.GameLogic.LevelController.Score = 0;
            SceneManager.LoadScene(1);
        }
    }
}