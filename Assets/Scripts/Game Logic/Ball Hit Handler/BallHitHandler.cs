using UnityEngine;

namespace BallTest.GameLogic
{
    public class BallHitHandler : MonoBehaviour
    {
        private IInputHandler InputHandler;
        private IHitedBallData HitedBallData;
        private IRayHit2DHandler RayHit2DHandler;

        private RaycastHit2D hitData;

        private bool isInput;

        void Awake()
        {
            InputHandler = GetComponent<IInputHandler>();
            HitedBallData = GetComponent<IHitedBallData>();
            RayHit2DHandler = GetComponent<IRayHit2DHandler>();
        }

        void Update()
        {
            if (!GamePlaybackController.isPauseGame)
                HandleHits();
        }

        private void HandleHits()
        {
            isInput = InputHandler.IsInputHappened();

            if (isInput)
            {
                hitData = RayHit2DHandler.IsItHit(InputHandler.GetHitPosition());

                if (hitData)
                {
                    HitedBallData.SetHitedBallData(hitData.transform.gameObject);
                    LevelController.Score++;
                }
            }
        }
    }
}