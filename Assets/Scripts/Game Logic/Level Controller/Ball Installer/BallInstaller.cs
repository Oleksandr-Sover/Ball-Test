using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public class BallInstaller : MonoBehaviour, IBallInstaller
    {
        private IBallByLevel BallByLevel;
        private ISpeedByLevel SpeedByLevel;
        private IBallStartingPosition BallStartingPosition;

        [SerializeField]
        private List<GameObject> prefabs = new List<GameObject>();

        private GameObject ball;

        void Awake()
        {
            BallByLevel = GetComponent<IBallByLevel>();
            SpeedByLevel = GetComponent<ISpeedByLevel>();
            BallStartingPosition = GetComponent<IBallStartingPosition>();
        }

        public void SetBall(int score)
        {
            ball = BallByLevel.ChooseBall(prefabs, score);
            SpeedByLevel.SetSpeed(ball, score);
            BallStartingPosition.SetStartPosition(ball);
        }
    }
}