using System.Collections.Generic;
using UnityEngine;

namespace BallTest.GameLogic
{
    public interface IBallMaker
    {
        public List<GameObject> PlayedBackBalls { get; set; }
        public List<GameObject> AllBalls { get; set; }
        public GameObject GetBall(GameObject prefab);
    }
}