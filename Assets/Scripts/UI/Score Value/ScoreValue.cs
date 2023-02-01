using TMPro;
using UnityEngine;

namespace BallTest.UI
{
    public class ScoreValue : MonoBehaviour
    {
        private INumberUpdater NumberUpdater;

        private TextMeshProUGUI scoreDisplay;

        void Awake()
        {
            scoreDisplay = GetComponent<TextMeshProUGUI>();
            NumberUpdater = GetComponent<INumberUpdater>();
        }

        void Update()
        {
            NumberUpdater.UpdateNumber(BallTest.GameLogic.LevelController.Score, scoreDisplay);
        }
    }
}