using UnityEngine;

namespace BallTest.GameLogic
{
    public class Movement : MonoBehaviour, IMovement
    {
        public IDirection Direction { get; set; }
        public float Speed { get; set; }

        private Vector2 direction;

        void Awake()
        {
            Direction = GetComponent<IDirection>();
        }

        void Update()
        {
            Move();
        }

        private void Move()
        {
            direction = Direction.GetDirection();
            transform.Translate(Speed * Time.deltaTime * direction);
        }
    }
}