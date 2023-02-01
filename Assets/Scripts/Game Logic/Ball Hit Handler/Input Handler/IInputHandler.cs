using UnityEngine;

namespace BallTest.GameLogic
{
    public interface IInputHandler
    {
        public bool IsInputHappened();
        public Vector3 GetHitPosition();
    }
}