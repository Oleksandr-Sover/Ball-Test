using UnityEngine;

namespace BallTest.GameLogic
{
    public interface IRayHit2DHandler
    {
        public RaycastHit2D IsItHit(Vector3 hitPosition);
    }
}