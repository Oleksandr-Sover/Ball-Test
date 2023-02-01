using UnityEngine;

namespace BallTest.GameLogic
{
    public class BallStartTimeByLevel : MonoBehaviour, IBallStartTimeByLevel
    {
        [SerializeField]
        private float startTimeBetweenStarts;
        [SerializeField]
        private float minTimeBetweenStarts;
        [SerializeField]
        private float deltaLevelTime;
        private float timeBetweenStarts;

        void Start()
        {
            timeBetweenStarts = startTimeBetweenStarts;
        }

        public float GetStartTime(int score)
        {
            if (timeBetweenStarts > minTimeBetweenStarts)
                timeBetweenStarts = startTimeBetweenStarts - score * deltaLevelTime;
            return timeBetweenStarts;
        }
    }
}