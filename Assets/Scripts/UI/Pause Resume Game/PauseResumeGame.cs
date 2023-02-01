using TMPro;
using UnityEngine;

namespace BallTest.UI
{
    public class PauseResumeGame : MonoBehaviour
    {
        private TextMeshProUGUI ButtonText;

        private string pause = "PAUSE";
        private string resume = "RESUME";

        public static bool isPauseGame;

        void Awake()
        {
            ButtonText = GetComponentInChildren<TextMeshProUGUI>();
        }

        public void PauseResume()
        {
            if (Time.timeScale > 0)
            {
                ButtonText.text = resume;
                BallTest.GameLogic.GamePlaybackController.Pause();
            }
            else
            {
                ButtonText.text = pause;
                BallTest.GameLogic.GamePlaybackController.Play();
            }
        }
    }
}