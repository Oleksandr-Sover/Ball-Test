using UnityEngine;

namespace BallTest.GameLogic
{
    public class BallStartingPosition : MonoBehaviour, IBallStartingPosition
    {
        public float StartYPosition { get; set; }

        private Vector2 startPosition = new Vector2(0, 0);

        [SerializeField]
        private float topMargin = 2;
        private float ballXSize;
        private float minX;
        private float maxX;
        private float randomX;

        void Start()
        {
            StartYPosition = GetStartYPosition();
        }

        public void SetStartPosition(GameObject ball)
        {
            GetRangeOfXPositions(ball);
            randomX = Random.Range(minX, maxX);
            startPosition.x = randomX;
            startPosition.y = StartYPosition;
            ball.transform.position = startPosition;
        }

        private float GetStartYPosition() => WorldScreenAngles.TopY + topMargin;

        private void GetRangeOfXPositions(GameObject ball)
        {
            ballXSize = ball.transform.localScale.x;
            minX = WorldScreenAngles.LeftX + ballXSize;
            maxX = WorldScreenAngles.RightX - ballXSize;
        }
    }
}