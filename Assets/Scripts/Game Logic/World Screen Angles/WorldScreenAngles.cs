using UnityEngine;

namespace BallTest.GameLogic
{
    public class WorldScreenAngles : MonoBehaviour
    {
        public static float RightX { get; private set; }
        public static float LeftX { get; private set; }
        public static float TopY { get; private set; }
        public static float BottomY { get; private set; }

        void Awake()
        {
            GetWorldScreenAngles();
        }

        private void GetWorldScreenAngles()
        {
            Vector2 topRightPosition = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
            Vector2 bottomLeftPosition = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));

            RightX = topRightPosition.x;
            LeftX = bottomLeftPosition.x;
            TopY = topRightPosition.y;
            BottomY = bottomLeftPosition.y;
        }
    }
}