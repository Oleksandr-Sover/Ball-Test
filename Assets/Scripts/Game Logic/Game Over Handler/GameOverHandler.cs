using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public class GameOverHandler : MonoBehaviour
    {
        private IBallMaker BallMaker;
        private IGameFinalizer GameFinalizer;

        [SerializeField]
        private List<GameObject> balls = new List<GameObject>();

        private bool handlerWorking;
        private bool isGameOver;

        void Awake()
        {
            BallMaker = FindObjectOfType<BallMaker>();
            GameFinalizer = GetComponent<IGameFinalizer>();
        }

        void Start()
        {
            StartCoroutine(HandleGameOver());
        }

        void Update()
        {
            if (!handlerWorking && !isGameOver)
                StartCoroutine(HandleGameOver());
        }

        private IEnumerator HandleGameOver()
        {
            handlerWorking = true;
            balls.Clear();
            balls.AddRange(BallMaker.AllBalls);

            foreach (var ball in balls)
            {
                if (ball.transform.position.y < WorldScreenAngles.BottomY)
                {
                    isGameOver = true;
                    GameFinalizer.FinalizeGame();
                    yield break;
                }
                yield return null;
            }
            handlerWorking = false;
        }
    }
}