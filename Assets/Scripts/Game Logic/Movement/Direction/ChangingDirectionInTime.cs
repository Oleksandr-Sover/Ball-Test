
using UnityEngine;

namespace BallTest.GameLogic
{
    public class ChangingDirectionInTime : MonoBehaviour, IDirection
    {
        private IChangeableDirection ChangeableDirection;

        private Vector2 direction;
        private Vector2 rightRebound;
        private Vector2 leftRebound;

        [SerializeField]
        private float maxTimer;
        [SerializeField]
        private float minTimer;
        private float timer;
        private float maxRightPosition;
        private float maxLeftPosition;

        void Awake()
        {
            ChangeableDirection = GetComponent<IChangeableDirection>();
        }

        void Start()
        {
            SetMaxPosition();
            rightRebound = VectorRotator.RotateVectorDown(-45);
            leftRebound = VectorRotator.RotateVectorDown(45);
        }

        void Update()
        {
            if (transform.position.x > maxRightPosition)
                direction = rightRebound;
            else if (transform.position.x < maxLeftPosition)
                direction = leftRebound;
            else if (timer > 0)
                timer -= Time.deltaTime;
            else
            {
                timer = SetTimer();
                direction = ChangeableDirection.GetChangeDirection();
            }
        }

        private void SetMaxPosition()
        {
            maxRightPosition = WorldScreenAngles.RightX - transform.localScale.x;
            maxLeftPosition = WorldScreenAngles.LeftX + transform.localScale.x;
        }

        private float SetTimer() => Random.Range(minTimer, maxTimer);

        public Vector2 GetDirection() => direction;
    }
}