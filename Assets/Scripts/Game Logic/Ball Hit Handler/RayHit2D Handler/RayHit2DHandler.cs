using UnityEngine;

namespace BallTest.GameLogic
{
    public class RayHit2DHandler : MonoBehaviour, IRayHit2DHandler
    {
        [SerializeField]
        private Camera mCamera;

        private Vector3 worldPosition;

        public RaycastHit2D IsItHit(Vector3 hitPosition)
        {
            worldPosition = mCamera.ScreenToWorldPoint(hitPosition);
            return Physics2D.Raycast((Vector2)worldPosition, Vector2.zero, 0);
        }
    }
}