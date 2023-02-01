using UnityEngine;

namespace BallTest.GameLogic
{
    public static class VectorRotator
    {
        public static Vector2 RotateVectorDown(int angle)
        {
            Quaternion quaternion = Quaternion.Euler(0, 0, angle);
            return quaternion * Vector2.down;
        }
    }
}