using UnityEngine;

namespace BallTest.GameLogic
{
    public class MouseInputHandler : MonoBehaviour, IInputHandler
    {
        public bool IsInputHappened() => Input.GetMouseButtonDown(0);
        public Vector3 GetHitPosition() => Input.mousePosition;
    }
}