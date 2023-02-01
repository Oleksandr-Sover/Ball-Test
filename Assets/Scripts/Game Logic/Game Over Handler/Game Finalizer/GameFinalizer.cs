using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace BallTest.GameLogic
{
    public class GameFinalizer : MonoBehaviour, IGameFinalizer
    {
        [SerializeField]
        private GameObject mainScenePage;
        [SerializeField]
        private GameObject gameOverPage;

        [SerializeField]
        private TextMeshProUGUI scoreText;

        [SerializeField]
        private float finalScoreDisplayTime;

        public void FinalizeGame()
        {
            StartCoroutine(FinalizingGame());
        }

        private IEnumerator FinalizingGame()
        {
            ShowEndPage();
            GamePlaybackController.isPauseGame = true;
            yield return new WaitForSeconds(finalScoreDisplayTime);
            SceneManager.LoadScene(0);
        }

        private void ShowEndPage()
        {
            gameOverPage.SetActive(true);
            mainScenePage.SetActive(false);
            scoreText.text = LevelController.Score.ToString();
        }
    }
}