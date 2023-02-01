using UnityEngine;

namespace BallTest.GameLogic
{
    public interface ISpeedByLevel
    {
        public void SetSpeed(GameObject ball, int score);
    }
}