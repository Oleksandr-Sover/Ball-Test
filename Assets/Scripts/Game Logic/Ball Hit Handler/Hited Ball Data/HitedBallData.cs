using UnityEngine;

namespace BallTest.GameLogic
{
    public class HitedBallData : MonoBehaviour, IHitedBallData
    {
        private IBallMaker BallMaker;
        private IHitEffectHandler HitEffectHandler;
        private IBallStartingPosition BallStartingPosition;

        private Vector2 restPosition = new Vector2(0, 0);

        void Awake()
        {
            HitEffectHandler = GetComponent<IHitEffectHandler>();
            BallMaker = FindObjectOfType<BallMaker>();
            BallStartingPosition = FindObjectOfType<BallStartingPosition>();
        }

        public void SetHitedBallData(GameObject hitGO)
        {
            HitEffectHandler.playHitEffect(hitGO);
            hitGO.transform.position = GetRestPositionValues(hitGO);
            BallMaker.PlayedBackBalls.Add(hitGO);
            hitGO.SetActive(false);
        }

        private Vector2 GetRestPositionValues(GameObject hitGO)
        {
            restPosition.x = hitGO.transform.position.x;
            restPosition.y = BallStartingPosition.StartYPosition;
            return restPosition;
        }
    }
}