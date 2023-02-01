using UnityEngine;

namespace BallTest.GameLogic
{
    public class SpeedByLevel : MonoBehaviour, ISpeedByLevel
    {
        [SerializeField]
        private float startSpeed = 1;
        [SerializeField]
        private float deltaLevelSpeed = 0.3f;
        private float speed;

        public void SetSpeed(GameObject ball, int score)
        {
            speed = startSpeed + score * deltaLevelSpeed;
            ball.GetComponent<IMovement>().Speed = speed;
        }
    }
}