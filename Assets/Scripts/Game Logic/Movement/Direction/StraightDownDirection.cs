using UnityEngine;

namespace BallTest.GameLogic
{
    public class StraightDownDirection : MonoBehaviour, IDirection
    {
        public Vector2 GetDirection() => Vector2.down;
    }
}