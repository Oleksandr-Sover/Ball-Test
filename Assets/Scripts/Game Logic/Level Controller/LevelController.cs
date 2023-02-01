using UnityEngine;

namespace BallTest.GameLogic
{
    public class LevelController : MonoBehaviour, ILevelController
    {
        public static int Score { get; set; }

        private IBallStartTimeByLevel BallStartTimeByLevel;
        private IBallInstaller BallInstaller;

        private float timer;

        void Awake()
        {
            BallStartTimeByLevel = GetComponent<IBallStartTimeByLevel>();
            BallInstaller = GetComponent<IBallInstaller>();
        }

        void Update()
        {
            UpdateLevel();
        }

        private void UpdateLevel()
        {
            if (timer > 0)
                timer -= Time.deltaTime;
            else
            {
                timer = BallStartTimeByLevel.GetStartTime(Score);
                BallInstaller.SetBall(Score);
            }
        }
    }
}