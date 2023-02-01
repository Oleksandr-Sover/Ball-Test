using UnityEngine;

namespace BallTest.GameLogic
{
    public class DownTurnRandomDirection : MonoBehaviour, IChangeableDirection
    {
        [SerializeField, Range(15, 60)]
        private int maxAngle;
        private int angle;

        public Vector2 GetChangeDirection()
        {
            angle = SetAngle();
            return VectorRotator.RotateVectorDown(angle);
        }

        private int SetAngle() => Random.Range(-maxAngle, maxAngle);
    }
}