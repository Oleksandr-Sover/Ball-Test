using UnityEngine;

namespace BallTest.GameLogic
{
    public interface IBallStartingPosition
    {
        public void SetStartPosition(GameObject ball);
        public float StartYPosition { get; set; }
    }
}