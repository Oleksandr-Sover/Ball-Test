using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public class BallMaker : MonoBehaviour, IBallMaker
    {
        private List<GameObject> playedBackBalls = new List<GameObject>();
        public List<GameObject> PlayedBackBalls { get => playedBackBalls; set => playedBackBalls = value; }

        private List<GameObject> allBalls = new List<GameObject>();
        public List<GameObject> AllBalls { get => allBalls; set => allBalls = value; }

        private GameObject ball;

        private int count;

        public GameObject GetBall(GameObject prefab)
        {
            count = playedBackBalls.Count;
            ball = null;

            if (count > 0)
            {
                foreach (GameObject playedBackBall in playedBackBalls)
                {
                    if (prefab.tag == playedBackBall.tag)
                    {
                        ball = playedBackBall;
                        break;
                    }
                }
                if (ball == null)
                    InstantiateBall(prefab);
                else
                    playedBackBalls.Remove(ball);
            }
            else
                InstantiateBall(prefab);

            ball.SetActive(true);
            return ball;
        }

        private void InstantiateBall(GameObject prefab)
        {
            ball = Instantiate(prefab);
            allBalls.Add(ball);
        }
    }
}